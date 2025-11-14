namespace AssetTool
{
    [JsonAsset("StateTreeComponent")]
    public class UStateTreeComponent : UBrainComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}