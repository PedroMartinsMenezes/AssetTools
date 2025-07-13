namespace AssetTool
{
    [JsonAsset("JumpFloodComponent2D")]
    public class UJumpFloodComponent2D : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}