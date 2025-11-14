namespace AssetTool
{
    [JsonAsset("ObjectElementCounterInterface")]
    public class UObjectElementCounterInterface : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}