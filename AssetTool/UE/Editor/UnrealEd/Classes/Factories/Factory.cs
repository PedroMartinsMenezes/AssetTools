namespace AssetTool
{
    [JsonAsset("Factory")]
    public class UFactory : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}