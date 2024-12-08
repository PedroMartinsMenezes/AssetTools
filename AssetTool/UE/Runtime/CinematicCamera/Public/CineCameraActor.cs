namespace AssetTool
{
    [JsonAsset("CineCameraActor")]
    public class ACineCameraActor : ACameraActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}