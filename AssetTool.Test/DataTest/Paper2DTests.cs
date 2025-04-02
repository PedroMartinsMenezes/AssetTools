using NUnit.Framework;

namespace AssetTool.Test
{
    public class Paper2DTests : TestBase
    {
        //public Paper2DTests() => GlobalNames.Clear();

        [Test] public void DefaultLitSpriteMaterial() => Assert.That(StructWriter.RebuildAsset("Paper2D/DefaultLitSpriteMaterial"));
        [Test] public void DefaultPaperTerrainMaterial() => Assert.That(StructWriter.RebuildAsset("Paper2D/DefaultPaperTerrainMaterial"));
        [Test] public void DefaultSpriteMaterial() => Assert.That(StructWriter.RebuildAsset("Paper2D/DefaultSpriteMaterial"));
        [Test] public void DummySprite() => Assert.That(StructWriter.RebuildAsset("Paper2D/DummySprite"));
        [Test] public void DummySpriteTexture() => Assert.That(StructWriter.RebuildAsset("Paper2D/DummySpriteTexture"));
        [Test] public void MaskedLitSpriteMaterial() => Assert.That(StructWriter.RebuildAsset("Paper2D/MaskedLitSpriteMaterial"));
        [Test] public void MaskedUnlitSpriteMaterial() => Assert.That(StructWriter.RebuildAsset("Paper2D/MaskedUnlitSpriteMaterial"));
        [Test] public void OpaqueLitSpriteMaterial() => Assert.That(StructWriter.RebuildAsset("Paper2D/OpaqueLitSpriteMaterial"));
        [Test] public void OpaqueUnlitSpriteMaterial() => Assert.That(StructWriter.RebuildAsset("Paper2D/OpaqueUnlitSpriteMaterial"));
        [Test] public void TranslucentLitSpriteMaterial() => Assert.That(StructWriter.RebuildAsset("Paper2D/TranslucentLitSpriteMaterial"));
        [Test] public void TranslucentUnlitSpriteMaterial() => Assert.That(StructWriter.RebuildAsset("Paper2D/TranslucentUnlitSpriteMaterial"));
    }
}