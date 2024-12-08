namespace AssetTool
{
    [JsonAsset("CameraActor")]
    public class ACameraActor : AActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}