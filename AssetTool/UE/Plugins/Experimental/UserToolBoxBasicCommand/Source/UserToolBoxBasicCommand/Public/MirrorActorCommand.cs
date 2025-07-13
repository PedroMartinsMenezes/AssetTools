namespace AssetTool
{
    [JsonAsset("MirrorActorCommand")]
    public class UMirrorActorCommand : UUTBBaseCommand
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}