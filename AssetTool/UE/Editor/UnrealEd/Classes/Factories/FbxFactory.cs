namespace AssetTool
{
    [JsonAsset("FbxFactory")]
    public class UFbxFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}