namespace AssetTool
{
    [JsonAsset("XRCreativePaletteTab")]
    public class UXRCreativePaletteTab : UCommonActivatableWidget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("XRCreativePalette")]
    public class UXRCreativePalette : UCommonActivatableWidget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("XRCreativeTool")]
    public class UXRCreativeTool : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("XRCreativeBlueprintableTool")]
    public class UXRCreativeBlueprintableTool : UXRCreativeTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("XRCreativePaletteToolTab")]
    public class UXRCreativePaletteToolTab : UXRCreativePaletteTab
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("XRCreativeToolset")]
    public class UXRCreativeToolset : UPrimaryDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}