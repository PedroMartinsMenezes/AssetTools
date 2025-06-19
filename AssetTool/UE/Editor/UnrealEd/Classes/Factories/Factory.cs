namespace AssetTool
{
    [JsonAsset("Factory")]
    public class UFactory : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}