namespace AssetTool
{
    [JsonAsset("IKRetargetFactory")]
    public class UIKRetargetFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}