// source: https://forum.unity.com/threads/exporting-skinned-mesh-to-obj-with-blendshapes-applyed-skinnedmeshrenderer-bakemesh.219033/#post-3500333

using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace net.voxint.MeshBaker
{
    public class MeshBaker : EditorWindow
    {
        [MenuItem("GameObject/Mesh baker/Bake mesh")]
        public static void SaveMeshInPlace(MenuCommand menuCommand)
        {
            switch (Selection.objects.Length)
            {
                case 0:

                //Prevent executing multiple times
                case > 1 when menuCommand.context != Selection.objects[0]:
                    return;
            }

            if (!EditorUtility.DisplayDialog("Mesh Baker", "Are you sure you want to bake the mesh?", "Yes", "No")) return;

            var selectedObject = Selection.gameObjects[0];
            var originalTransform = selectedObject.transform;
            var originalName = selectedObject.name;
            var parentObject = selectedObject.transform.parent.gameObject.transform;
            var skinnedMeshRenderer = selectedObject.GetComponent<SkinnedMeshRenderer>();
            var materials = skinnedMeshRenderer.sharedMaterials;

            // Bake the mesh
            var bakeMesh = new Mesh();
            if (skinnedMeshRenderer != null) skinnedMeshRenderer.BakeMesh(bakeMesh);

            // Save baked mesh to disk
            SaveMesh(bakeMesh, bakeMesh.name, false, true);

            // Create new game object with the baked mesh
            var bakedMeshObject = new GameObject(originalName);
            bakedMeshObject.transform.parent = parentObject;
            bakedMeshObject.transform.SetPositionAndRotation(originalTransform.position, originalTransform.rotation);
            bakedMeshObject.transform.localScale = originalTransform.localScale;
            var meshFilter = Undo.AddComponent<MeshFilter>(bakedMeshObject);
            meshFilter.mesh = bakeMesh;
            var meshRenderer = Undo.AddComponent<MeshRenderer>(bakedMeshObject);
            meshRenderer.sharedMaterials = materials;

            // Remove original object
            Undo.DestroyObjectImmediate(selectedObject);
        }

        private static void SaveMesh(Mesh mesh, string name, bool makeNewInstance, bool optimizeMesh)
        {
            var path = EditorUtility.SaveFilePanel("Save Separate Mesh Asset", "Assets/", name, "asset");
            if (string.IsNullOrEmpty(path)) return;

            path = FileUtil.GetProjectRelativePath(path);

            var meshToSave = (makeNewInstance) ? Instantiate(mesh) : mesh;

            if (optimizeMesh)
                MeshUtility.Optimize(meshToSave);

            AssetDatabase.CreateAsset(meshToSave, path);
            AssetDatabase.SaveAssets();
        }
    }
}