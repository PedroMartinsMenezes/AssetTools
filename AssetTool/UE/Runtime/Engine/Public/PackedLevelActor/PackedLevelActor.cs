namespace AssetTool
{
    [JsonAsset("PackedLevelActor")]
    public class APackedLevelActor : ALevelInstance
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}