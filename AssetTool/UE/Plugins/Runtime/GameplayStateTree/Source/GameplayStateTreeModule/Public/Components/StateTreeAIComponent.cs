namespace AssetTool
{
    [JsonAsset("StateTreeAIComponent")]
    public class UStateTreeAIComponent : UStateTreeComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}