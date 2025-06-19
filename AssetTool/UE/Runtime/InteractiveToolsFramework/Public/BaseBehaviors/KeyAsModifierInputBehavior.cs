namespace AssetTool
{
    [JsonAsset("KeyAsModifierInputBehavior")]
    public class UKeyAsModifierInputBehavior : UInputBehavior
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}