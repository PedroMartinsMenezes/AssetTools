namespace AssetTool
{
    [JsonAsset("ModularSynthPresetBank")]
    public class UModularSynthPresetBank : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ModularSynthLibrary")]
    public class UModularSynthLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ModularSynthComponent")]
    public class UModularSynthComponent : USynthComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}