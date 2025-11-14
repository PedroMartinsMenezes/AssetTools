namespace AssetTool
{
    [JsonAsset("ObjectElementDetailsInterface")]
    public class UObjectElementDetailsInterface : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}