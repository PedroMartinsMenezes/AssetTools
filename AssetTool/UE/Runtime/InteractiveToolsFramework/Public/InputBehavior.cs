namespace AssetTool
{
    [JsonAsset("InputBehavior")]
    public class UInputBehavior : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}