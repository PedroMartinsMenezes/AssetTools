namespace AssetTool
{
    [JsonAsset("KeyInputBehavior")]
    public class UKeyInputBehavior : UInputBehavior
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}