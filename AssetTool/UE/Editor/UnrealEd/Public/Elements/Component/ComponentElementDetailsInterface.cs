namespace AssetTool
{
    [JsonAsset("ComponentElementDetailsInterface")]
    public class UComponentElementDetailsInterface : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}