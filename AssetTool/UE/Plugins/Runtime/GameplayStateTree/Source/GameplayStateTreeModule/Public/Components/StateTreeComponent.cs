namespace AssetTool
{
    [JsonAsset("StateTreeComponent")]
    public class UStateTreeComponent : UBrainComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}