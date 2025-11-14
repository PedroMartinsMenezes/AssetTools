namespace AssetTool
{
    [JsonAsset("XRCreativePaletteTab")]
    public class UXRCreativePaletteTab : UCommonActivatableWidget
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("XRCreativePalette")]
    public class UXRCreativePalette : UCommonActivatableWidget
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("XRCreativeTool")]
    public class UXRCreativeTool : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("XRCreativeBlueprintableTool")]
    public class UXRCreativeBlueprintableTool : UXRCreativeTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("XRCreativePaletteToolTab")]
    public class UXRCreativePaletteToolTab : UXRCreativePaletteTab
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("XRCreativeToolset")]
    public class UXRCreativeToolset : UPrimaryDataAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}