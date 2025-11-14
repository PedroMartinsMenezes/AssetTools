namespace AssetTool
{
    [JsonAsset("StateTreeAIComponent")]
    public class UStateTreeAIComponent : UStateTreeComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}