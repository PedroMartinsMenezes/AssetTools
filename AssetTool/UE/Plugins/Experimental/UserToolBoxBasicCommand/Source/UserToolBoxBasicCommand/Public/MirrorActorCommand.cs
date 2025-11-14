namespace AssetTool
{
    [JsonAsset("MirrorActorCommand")]
    public class UMirrorActorCommand : UUTBBaseCommand
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}