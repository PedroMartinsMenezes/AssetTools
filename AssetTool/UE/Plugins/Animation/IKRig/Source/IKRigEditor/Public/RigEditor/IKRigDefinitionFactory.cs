namespace AssetTool
{
    [JsonAsset("IKRigDefinitionFactory")]
    public class UIKRigDefinitionFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}