namespace AssetTool
{
    [JsonAsset("BlendListBaseLibrary")]
    public class UBlendListBaseLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}