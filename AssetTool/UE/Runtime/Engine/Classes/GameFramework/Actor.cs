namespace AssetTool
{
    [JsonAsset("AActor")]
    public class AActor : UObject
    {
        public FBool bIsCooked;
        public FString ActorLabel;

        [Location("void AActor::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            base.Move(transfer);

            transfer.Move(ref bIsCooked);
            if (bIsCooked.Value)
            {
                transfer.Move(ref ActorLabel);
            }

            return this;
        }
    }
}