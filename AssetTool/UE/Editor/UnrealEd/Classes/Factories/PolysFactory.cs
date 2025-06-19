namespace AssetTool
{
    [JsonAsset("PolysFactory")]
    public class UPolysFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}