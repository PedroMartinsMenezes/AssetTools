namespace AssetTool
{
    [JsonAsset("KeyInputBehavior")]
    public class UKeyInputBehavior : UInputBehavior
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}