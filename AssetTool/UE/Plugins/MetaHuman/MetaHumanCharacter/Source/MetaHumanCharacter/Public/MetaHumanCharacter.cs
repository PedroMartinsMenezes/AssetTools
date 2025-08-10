namespace AssetTool
{
    [JsonAsset("MetaHumanCharacterThumbnailAux")]
    public class UMetaHumanCharacterThumbnailAux : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MetaHumanCharacter")]
    public class UMetaHumanCharacter : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}