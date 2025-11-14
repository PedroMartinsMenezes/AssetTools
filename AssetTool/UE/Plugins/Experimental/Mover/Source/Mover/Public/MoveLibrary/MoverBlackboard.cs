namespace AssetTool
{
    [JsonAsset("MoverBlackboard")]
    public class UMoverBlackboard : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}