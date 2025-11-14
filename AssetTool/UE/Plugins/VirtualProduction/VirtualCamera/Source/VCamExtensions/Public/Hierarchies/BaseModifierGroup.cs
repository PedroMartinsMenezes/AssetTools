namespace AssetTool
{
    [JsonAsset("BaseModifierGroup")]
    public class UBaseModifierGroup : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}