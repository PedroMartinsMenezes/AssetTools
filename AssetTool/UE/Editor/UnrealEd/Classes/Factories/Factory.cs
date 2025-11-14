namespace AssetTool
{
    [JsonAsset("Factory")]
    public class UFactory : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}