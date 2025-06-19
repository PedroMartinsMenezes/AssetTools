namespace AssetTool
{
    [JsonAsset("AISenseBlueprintListener")]
    public class UAISenseBlueprintListener : UUserDefinedStruct
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}