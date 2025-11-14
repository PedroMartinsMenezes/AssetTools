namespace AssetTool
{
    [JsonAsset("StateTreeState")]
    public class UStateTreeState : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}