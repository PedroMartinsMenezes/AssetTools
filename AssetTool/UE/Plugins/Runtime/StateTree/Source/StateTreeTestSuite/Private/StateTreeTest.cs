namespace AssetTool
{
    [JsonAsset("StateTreeTestSchema")]
    public class UStateTreeTestSchema : UStateTreeSchema
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}