namespace AssetTool
{
    [JsonAsset("MovementModeStateMachine")]
    public class UMovementModeStateMachine : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}