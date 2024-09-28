namespace AssetTool.Test
{
    [Collection("Sequential")]
    public class Paper2DTests : TestBase
    {
        public Paper2DTests() => GlobalNames.Clear();

        [Fact] public void DefaultLitSpriteMaterial() => Assert.True(StructWriter.RebuildAsset("Paper2D/DefaultLitSpriteMaterial"));
        [Fact] public void DefaultPaperTerrainMaterial() => Assert.True(StructWriter.RebuildAsset("Paper2D/DefaultPaperTerrainMaterial"));
        [Fact] public void DefaultSpriteMaterial() => Assert.True(StructWriter.RebuildAsset("Paper2D/DefaultSpriteMaterial"));
        [Fact] public void DummySprite() => Assert.True(StructWriter.RebuildAsset("Paper2D/DummySprite"));
        [Fact] public void DummySpriteTexture() => Assert.True(StructWriter.RebuildAsset("Paper2D/DummySpriteTexture"));
        [Fact] public void MaskedLitSpriteMaterial() => Assert.True(StructWriter.RebuildAsset("Paper2D/MaskedLitSpriteMaterial"));
        [Fact] public void MaskedUnlitSpriteMaterial() => Assert.True(StructWriter.RebuildAsset("Paper2D/MaskedUnlitSpriteMaterial"));
        [Fact] public void OpaqueLitSpriteMaterial() => Assert.True(StructWriter.RebuildAsset("Paper2D/OpaqueLitSpriteMaterial"));
        [Fact] public void OpaqueUnlitSpriteMaterial() => Assert.True(StructWriter.RebuildAsset("Paper2D/OpaqueUnlitSpriteMaterial"));
        [Fact] public void TranslucentLitSpriteMaterial() => Assert.True(StructWriter.RebuildAsset("Paper2D/TranslucentLitSpriteMaterial"));
        [Fact] public void TranslucentUnlitSpriteMaterial() => Assert.True(StructWriter.RebuildAsset("Paper2D/TranslucentUnlitSpriteMaterial"));
    }
}