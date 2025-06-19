namespace AssetTool
{
    [JsonAsset("KeyInputBehavior")]
    public class UKeyInputBehavior : UInputBehavior
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}