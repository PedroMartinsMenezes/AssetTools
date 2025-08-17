namespace AssetTool
{
    [JsonAsset("CineAssemblyFactory")]
    public class UCineAssemblyFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}