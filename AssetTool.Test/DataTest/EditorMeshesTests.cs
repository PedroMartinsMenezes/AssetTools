namespace AssetTool.Test
{
    [Collection("Sequential")]
    public class EditorMeshesTests : TestBase
    {
        public EditorMeshesTests() => GlobalNames.Clear();

        [Fact] public void AnimTreeEd_PreviewFloor() => Assert.True(StructWriter.RebuildAsset("EditorMeshes/AnimTreeEd_PreviewFloor"));
        [Fact] public void ArcadeEditorSphere() => Assert.True(StructWriter.RebuildAsset("EditorMeshes/ArcadeEditorSphere"));
        [Fact] public void Axis_Guide() => Assert.True(StructWriter.RebuildAsset("EditorMeshes/Axis_Guide"));
        [Fact] public void EditorCube() => Assert.True(StructWriter.RebuildAsset("EditorMeshes/EditorCube"));
        [Fact] public void EditorCylinder() => Assert.True(StructWriter.RebuildAsset("EditorMeshes/EditorCylinder"));
        [Fact] public void EditorHelp() => Assert.True(StructWriter.RebuildAsset("EditorMeshes/EditorHelp"));
        [Fact] public void EditorPlane() => Assert.True(StructWriter.RebuildAsset("EditorMeshes/EditorPlane"));
        [Fact] public void EditorSkySphere() => Assert.True(StructWriter.RebuildAsset("EditorMeshes/EditorSkySphere"));
        [Fact] public void EditorSphere() => Assert.True(StructWriter.RebuildAsset("EditorMeshes/EditorSphere"));
        [Fact] public void MatineeCam_SM() => Assert.True(StructWriter.RebuildAsset("EditorMeshes/MatineeCam_SM"));
        [Fact] public void PhAT_FloorBox() => Assert.True(StructWriter.RebuildAsset("EditorMeshes/PhAT_FloorBox"));
        [Fact] public void PlanarReflectionPlane() => Assert.True(StructWriter.RebuildAsset("EditorMeshes/PlanarReflectionPlane"));

        //[Fact] public void DefaultSkeletalMesh() => Assert.True(StructWriter.RebuildAsset("EditorMeshes/SkeletalMesh/DefaultSkeletalMesh"));
        //[Fact] public void DefaultSkeletalMesh_Skeleton() => Assert.True(StructWriter.RebuildAsset("EditorMeshes/SkeletalMesh/DefaultSkeletalMesh_Skeleton"));
    }
}