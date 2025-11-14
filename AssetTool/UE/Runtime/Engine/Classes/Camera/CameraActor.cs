namespace AssetTool
{
    [JsonAsset("CameraActor")]
    public class ACameraActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}