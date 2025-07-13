namespace AssetTool
{
    [JsonAsset("BaseModifierGroup")]
    public class UBaseModifierGroup : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}