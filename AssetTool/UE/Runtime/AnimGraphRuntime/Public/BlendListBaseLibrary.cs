namespace AssetTool
{
    [JsonAsset("BlendListBaseLibrary")]
    public class UBlendListBaseLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}