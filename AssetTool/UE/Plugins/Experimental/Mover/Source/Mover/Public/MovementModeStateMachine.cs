namespace AssetTool
{
    [JsonAsset("MovementModeStateMachine")]
    public class UMovementModeStateMachine : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}