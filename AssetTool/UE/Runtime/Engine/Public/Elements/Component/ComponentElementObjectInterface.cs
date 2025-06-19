namespace AssetTool
{
    [JsonAsset("ComponentElementObjectInterface")]
    public class UComponentElementObjectInterface : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}