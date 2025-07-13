namespace AssetTool
{
    [JsonAsset("SubSubobject")]
    public class USubSubobject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("Subobject")]
    public class USubobject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SnapshotTestComponent")]
    public class USnapshotTestComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SnapshotTestActor")]
    public class ASnapshotTestActor : ACharacter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}