namespace AssetTool
{
    [JsonAsset("Scene")]
    public class UScene : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}