using NUnit.Framework;

namespace AssetTool.Test
{
    public class EditorMeshesTests : TestBase
    {
        //public EditorMeshesTests() => GlobalNames.Clear();

        [Test] public void AnimTreeEd_PreviewFloor() => Assert.That(StructWriter.RebuildAsset("EditorMeshes/AnimTreeEd_PreviewFloor"));
        [Test] public void ArcadeEditorSphere() => Assert.That(StructWriter.RebuildAsset("EditorMeshes/ArcadeEditorSphere"));
        [Test] public void Axis_Guide() => Assert.That(StructWriter.RebuildAsset("EditorMeshes/Axis_Guide"));
        [Test] public void EditorCube() => Assert.That(StructWriter.RebuildAsset("EditorMeshes/EditorCube"));
        [Test] public void EditorCylinder() => Assert.That(StructWriter.RebuildAsset("EditorMeshes/EditorCylinder"));
        [Test] public void EditorHelp() => Assert.That(StructWriter.RebuildAsset("EditorMeshes/EditorHelp"));
        [Test] public void EditorPlane() => Assert.That(StructWriter.RebuildAsset("EditorMeshes/EditorPlane"));
        [Test] public void EditorSkySphere() => Assert.That(StructWriter.RebuildAsset("EditorMeshes/EditorSkySphere"));
        [Test] public void EditorSphere() => Assert.That(StructWriter.RebuildAsset("EditorMeshes/EditorSphere"));
        [Test] public void MatineeCam_SM() => Assert.That(StructWriter.RebuildAsset("EditorMeshes/MatineeCam_SM"));
        [Test] public void PhAT_FloorBox() => Assert.That(StructWriter.RebuildAsset("EditorMeshes/PhAT_FloorBox"));
        [Test] public void PlanarReflectionPlane() => Assert.That(StructWriter.RebuildAsset("EditorMeshes/PlanarReflectionPlane"));

        [Test] public void DefaultSkeletalMesh() => Assert.That(StructWriter.RebuildAsset("EditorMeshes/SkeletalMesh/DefaultSkeletalMesh"));
        [Test] public void DefaultSkeletalMesh_Skeleton() => Assert.That(StructWriter.RebuildAsset("EditorMeshes/SkeletalMesh/DefaultSkeletalMesh_Skeleton"));
    }
}