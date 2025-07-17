namespace AssetTool
{
    [JsonAsset("LyraCharacterWithAbilities")]
    public class ALyraCharacterWithAbilities : ALyraCharacter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}