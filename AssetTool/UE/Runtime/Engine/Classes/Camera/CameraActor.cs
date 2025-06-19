namespace AssetTool
{
    [JsonAsset("CameraActor")]
    public class ACameraActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}