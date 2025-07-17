namespace AssetTool
{
    [JsonAsset("ModularCharacter")]
    public class AModularCharacter : ACharacter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}