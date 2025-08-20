namespace AssetTool
{
    [JsonAsset("World")]
    public class UWorld : UObject
    {
        public FObjectPtr PersistentLevel;
        public FLevelViewportInfo[] TempViewportInfo;
        public UInt32 DummyObject;
        public List<FObjectPtr> ExtraReferencedObjects;
        public List<FObjectPtr> StreamingLevels;

        [Location("void UWorld::Serialize( FArchive& Ar )")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref PersistentLevel);
            if (!transfer.Supports.VER_UE4_ADD_EDITOR_VIEWS)
            {
                transfer.Move(ref TempViewportInfo, 4);
            }
            if (!transfer.Supports.VER_UE4_REMOVE_SAVEGAMESUMMARY)
            {
                transfer.Move(ref DummyObject);
            }
            transfer.Move(ref ExtraReferencedObjects);
            transfer.Move(ref StreamingLevels);
            return this;
        }
    }

    public struct FLevelViewportInfo : ITransferible
    {
        public FVector CamPosition;
        public FRotator CamRotation;
        public float CamOrthoZoom;

        [Location("friend FArchive& operator<<( FArchive& Ar, FLevelViewportInfo& I )")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref CamPosition);
            transfer.Move(ref CamRotation);
            transfer.Move(ref CamOrthoZoom);
            return this;
        }
    }
}