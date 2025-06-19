namespace AssetTool
{
    [JsonAsset("ComponentElementWorldInterface")]
    public class UComponentElementWorldInterface : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}