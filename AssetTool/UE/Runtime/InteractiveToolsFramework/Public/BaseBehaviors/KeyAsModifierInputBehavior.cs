namespace AssetTool
{
    [JsonAsset("KeyAsModifierInputBehavior")]
    public class UKeyAsModifierInputBehavior : UInputBehavior
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}