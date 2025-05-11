using System.Text.Json.Serialization;

namespace AssetTool
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "__type")]
    [JsonDerivedType(typeof(FRigTransformElement), nameof(FRigTransformElement))]
    [JsonDerivedType(typeof(FRigSingleParentElement), nameof(FRigSingleParentElement))]
    [JsonDerivedType(typeof(FRigBoneElement), nameof(FRigBoneElement))]
    [JsonDerivedType(typeof(FRigReferenceElement), nameof(FRigReferenceElement))]
    [JsonDerivedType(typeof(FRigMultiParentElement), nameof(FRigMultiParentElement))]
    [JsonDerivedType(typeof(FRigNullElement), nameof(FRigNullElement))]
    [JsonDerivedType(typeof(FRigControlElement), nameof(FRigControlElement))]
    [JsonDerivedType(typeof(FRigCurveElement), nameof(FRigCurveElement))]
    [JsonDerivedType(typeof(FRigPhysicsElement), nameof(FRigPhysicsElement))]
    [JsonDerivedType(typeof(FRigConnectorElement), nameof(FRigConnectorElement))]
    [JsonDerivedType(typeof(FRigSocketElement), nameof(FRigSocketElement))]
    public class FRigBaseElement : ITransferibleContext
    {
        protected ESerializationPhase SerializationPhase;
        public FRigElementKey LoadedKey;
        public Int32 MetadataNum;
        public List<FName> MetadataNames = [];
        public List<FName> MetadataTypeNames = [];
        public List<FRigBaseMetadata> Mds = [];

        public virtual ITransferible Move(Transfer transfer, params object[] args)
        {
            SerializationPhase = (ESerializationPhase)args[0];
            return Move(transfer);
        }

        [Location("void FRigBaseElement::Load(FArchive& Ar, ESerializationPhase SerializationPhase)")]
        public virtual ITransferible Move(Transfer transfer)
        {
            if (SerializationPhase == ESerializationPhase.StaticData)
            {
                transfer.Move(ref LoadedKey);
                if (transfer.Supports.HierarchyElementMetadata && !transfer.Supports.RigHierarchyStoresElementMetadata)
                {
                    transfer.Move(ref MetadataNum);
                    MetadataNames = MetadataNames.Resize(transfer, MetadataNum);
                    MetadataTypeNames = MetadataTypeNames.Resize(transfer, MetadataNum);
                    Mds = Mds.Resize(transfer, MetadataNum);
                    for (int MetadataIndex = 0; MetadataIndex < MetadataNum; MetadataIndex++)
                    {
                        MetadataNames[MetadataIndex].Move(transfer);
                        MetadataTypeNames[MetadataIndex].Move(transfer);
                        Mds[MetadataIndex].Move(transfer);
                    }
                }
            }
            return this;
        }
    }

    public class FRigTransformElement : FRigBaseElement
    {
        public FRigCurrentAndInitialTransform Pose;

        [Location("void FRigTransformElement::Load(FArchive& Ar, ESerializationPhase SerializationPhase)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            if (SerializationPhase == ESerializationPhase.StaticData)
            {
                transfer.Move(ref Pose);
            }
            return this;
        }
    }

    public class FRigSingleParentElement : FRigTransformElement
    {
        public FRigElementKey ParentKey;

        [Location("void FRigSingleParentElement::Load(FArchive& Ar, ESerializationPhase SerializationPhase)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            if (SerializationPhase == ESerializationPhase.InterElementData)
            {
                transfer.Move(ref ParentKey);
            }
            return this;
        }
    }

    public class FRigBoneElement : FRigSingleParentElement
    {
        public FName TypeName;

        [Location("void FRigBoneElement::Load(FArchive& Ar, URigHierarchy* Hierarchy, ESerializationPhase SerializationPhase)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            if (SerializationPhase == ESerializationPhase.StaticData)
            {
                transfer.Move(ref TypeName);
            }
            return this;
        }
    }

    public class FRigCurrentAndInitialTransform : ITransferible
    {
        public FRigLocalAndGlobalTransform Current;
        public FRigLocalAndGlobalTransform Initial;

        [Location("void FRigCurrentAndInitialTransform::Load(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Current);
            transfer.Move(ref Initial);
            return this;
        }
    }

    public class FRigLocalAndGlobalTransform : ITransferible
    {
        public FRigComputedTransform Local;
        public FRigComputedTransform Global;

        [Location("void FRigLocalAndGlobalTransform::Load(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Local);
            transfer.Move(ref Global);
            return this;
        }
    }

    public class FRigComputedTransform : ITransferible
    {
        public FTransform Transform;
        public FBool bDirty;

        [Location("void FRigComputedTransform::Save(FArchive& Ar, bool& bDirty)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Transform);
            transfer.Move(ref bDirty);
            return this;
        }
    }

    public class FRigNullElement : FRigMultiParentElement
    {

    }

    public class FRigMultiParentElement : FRigTransformElement
    {
        public FRigCurrentAndInitialTransform Parent;
        public Int32 NumParents;
        public List<FRigElementParentConstraint> ParentConstraints = [];
        public List<FRigElementKey> ParentKeys = [];

        [Location("void FRigMultiParentElement::Load(FArchive& Ar, URigHierarchy* Hierarchy, ESerializationPhase SerializationPhase)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            if (SerializationPhase == ESerializationPhase.StaticData)
            {
                if (!transfer.Supports.RemovedMultiParentParentCache)
                {
                    transfer.Move(ref Parent);
                }

                transfer.Move(ref NumParents);
                ParentConstraints = ParentConstraints.Resize(transfer, NumParents);
            }
            else if (SerializationPhase == ESerializationPhase.InterElementData)
            {
                ParentKeys = ParentKeys.Resize(transfer, ParentConstraints.Count);
                for (int ParentIndex = 0; ParentIndex < ParentConstraints.Count; ParentIndex++)
                {
                    ParentKeys[ParentIndex].Move(transfer);

                    if (transfer.Supports.RigHierarchyMultiParentConstraints)
                    {
                        transfer.Move(ref ParentConstraints[ParentIndex].InitialWeight);
                        transfer.Move(ref ParentConstraints[ParentIndex].Weight);
                    }
                    else
                    {
                        ParentConstraints[ParentIndex].InitialWeight.MoveFloat(transfer);
                        ParentConstraints[ParentIndex].Weight.MoveFloat(transfer);
                    }
                }
            }
            return this;
        }
    }

    public class FRigElementParentConstraint
    {
        public FRigTransformElement ParentElement;
        public FRigElementWeight InitialWeight = new();
        public FRigElementWeight Weight = new();
    }

    public class FRigElementWeight : ITransferible
    {
        public float Location;
        public float Rotation;
        public float Scale;

        [Location("friend FArchive& operator <<(FArchive& Ar, FRigElementWeight& Weight)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Location);
            transfer.Move(ref Rotation);
            transfer.Move(ref Scale);
            return this;
        }

        public ITransferible MoveFloat(Transfer transfer)
        {
            transfer.Move(ref Location);
            Rotation = Location;
            Scale = Location;
            return this;
        }
    }

    public class FRigControlElement : FRigMultiParentElement
    {
        public FRigControlSettings Settings;
        public FRigCurrentAndInitialTransform Offset;
        public FRigCurrentAndInitialTransform Shape;
        public FRigPreferredEulerAngles PreferredEulerAngles;

        [Location("void FRigControlElement::Load(FArchive& Ar, URigHierarchy* Hierarchy, ESerializationPhase SerializationPhase)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            if (SerializationPhase == ESerializationPhase.StaticData)
            {
                transfer.Move(ref Settings);
                transfer.Move(ref Offset);
                transfer.Move(ref Shape);

                if (transfer.Supports.PreferredEulerAnglesForControls)
                {
                    transfer.Move(ref PreferredEulerAngles);
                }
            }
            return this;
        }
    }

    public class FRigControlSettings : ITransferible
    {
        public FName AnimationTypeName;
        public FName ControlTypeName;
        public FName DisplayName;
        public FName PrimaryAxisName;
        public FBool bIsCurve;
        public FBool bAnimatableDeprecated;
        public FBool bLimitTranslation_DEPRECATED;
        public FBool bLimitRotation_DEPRECATED;
        public FBool bLimitScale_DEPRECATED;
        public List<FRigControlLimitEnabled> LimitEnabled;
        public FBool bDrawLimits;
        public FRigControlValue MinimumValue;
        public FRigControlValue MaximumValue;
        public FTransform MinimumTransform;
        public FTransform MaximumTransform;
        public FBool bShapeEnabledDeprecated;
        public FBool bShapeVisible;
        public FName ShapeVisibilityName;
        public FName ShapeName;
        public FLinearColor ShapeColor;
        public FBool bIsTransientControl;
        public FString ControlEnumPathName;
        public FRigControlElementCustomization Customization = new();
        public List<FRigElementKey> DrivenControls;
        public FBool bGroupWithParentControl;
        public FBool bRestrictSpaceSwitching;
        public List<ERigControlTransformChannel> FilteredChannels;
        public EEulerRotationOrder PreferredRotationOrder;
        public FBool bUsePreferredRotationOrder;

        [Location("void FRigControlSettings::Load(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            if (transfer.Supports.ControlAnimationType)
            {
                transfer.Move(ref AnimationTypeName);
            }
            transfer.Move(ref ControlTypeName);
            transfer.Move(ref DisplayName);
            transfer.Move(ref PrimaryAxisName);
            transfer.Move(ref bIsCurve);
            if (!transfer.Supports.ControlAnimationType)
            {
                transfer.Move(ref bAnimatableDeprecated);
            }
            if (!transfer.Supports.PerChannelLimits)
            {
                transfer.Move(ref bLimitTranslation_DEPRECATED);
                transfer.Move(ref bLimitRotation_DEPRECATED);
                transfer.Move(ref bLimitScale_DEPRECATED);
            }
            else
            {
                transfer.Move(ref LimitEnabled);
            }
            transfer.Move(ref bDrawLimits);

            if (transfer.Supports.StorageMinMaxValuesAsFloatStorage)
            {
                transfer.Move(ref MinimumValue);
                transfer.Move(ref MaximumValue);
            }
            else
            {
                transfer.Move(ref MinimumTransform);
                transfer.Move(ref MaximumTransform);
            }

            if (!transfer.Supports.ControlAnimationType)
            {
                transfer.Move(ref bShapeEnabledDeprecated);
            }

            transfer.Move(ref bShapeVisible);

            if (transfer.Supports.ControlAnimationType)
            {
                transfer.Move(ref ShapeVisibilityName);
            }
            transfer.Move(ref ShapeName);

            transfer.Move(ref ShapeColor);
            transfer.Move(ref bIsTransientControl);
            transfer.Move(ref ControlEnumPathName);

            if (transfer.Supports.RigHierarchyControlSpaceFavorites)
            {
                transfer.Move(ref Customization.AvailableSpaces);
            }

            if (transfer.Supports.ControlAnimationType)
            {
                transfer.Move(ref DrivenControls);
            }

            if (transfer.Supports.ControlAnimationType)
            {
                transfer.Move(ref bGroupWithParentControl);
            }

            if (transfer.Supports.RestrictSpaceSwitchingForControls)
            {
                transfer.Move(ref bRestrictSpaceSwitching);
            }

            if (transfer.Supports.ControlTransformChannelFiltering)
            {
                FilteredChannels = FilteredChannels.Resize(transfer);
                for (int i = 0; i < FilteredChannels.Count; i++)
                {
                    FilteredChannels[i] = (ERigControlTransformChannel)transfer.Move((byte)FilteredChannels[i]);
                }
            }

            if (transfer.Supports.RigHierarchyControlPreferredRotationOrder)
                PreferredRotationOrder = (EEulerRotationOrder)transfer.Move((byte)PreferredRotationOrder);

            if (transfer.Supports.RigHierarchyControlPreferredRotationOrderFlag)
                transfer.Move(ref bUsePreferredRotationOrder);

            return this;
        }
    }

    public class FRigPreferredEulerAngles : ITransferible
    {
        public FName RotationOrderName;
        public FVector Current;
        public FVector Initial;

        [Location("void FRigPreferredEulerAngles::Load(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref RotationOrderName);
            transfer.Move(ref Current);
            transfer.Move(ref Initial);
            return this;
        }
    }

    public class FRigControlElementCustomization
    {
        public List<FRigElementKey> AvailableSpaces = [];
        public List<FRigElementKey> RemovedSpaces = [];
    }

    public class FRigCurveElement : FRigBaseElement
    {
        public FBool bIsValueSet;
        public float Value;

        [Location("void FRigCurveElement::Load(FArchive& Ar, URigHierarchy* Hierarchy, ESerializationPhase SerializationPhase)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            if (SerializationPhase == ESerializationPhase.StaticData)
            {
                if (transfer.Supports.CurveElementValueStateFlag)
                {
                    transfer.Move(ref bIsValueSet);
                }
                transfer.Move(ref Value);
            }
            return this;
        }
    }

    public class FRigPhysicsElement : FRigSingleParentElement
    {
        public FRigPhysicsSolverID Solver;
        public FRigPhysicsSettings Settings;

        [Location("void FRigPhysicsElement::Load(FArchive& Ar, ESerializationPhase SerializationPhase)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            if (SerializationPhase == ESerializationPhase.StaticData)
            {
                transfer.Move(ref Solver);
                transfer.Move(ref Settings);
            }
            return this;
        }
    }

    public class FRigPhysicsSolverID : ITransferible
    {
        public FGuid Guid;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Guid);
            return this;
        }
    }

    public class FRigPhysicsSettings : ITransferible
    {
        public float Mass;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Mass);
            return this;
        }
    }

    public class FRigRigidBodySettings : ITransferible
    {
        public float Mass;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Mass);
            return this;
        }
    }

    public class FRigReferenceElement : FRigSingleParentElement
    {
        [Location("void FRigReferenceElement::Load(FArchive& Ar, URigHierarchy* Hierarchy, ESerializationPhase SerializationPhase)")]
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    public class FRigConnectorElement : FRigBaseElement
    {
        public FRigConnectorSettings Settings;

        [Location("void FRigConnectorElement::Load(FArchive& Ar, ESerializationPhase SerializationPhase)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            if (SerializationPhase == ESerializationPhase.StaticData)
            {
                transfer.Move(ref Settings);
            }
            return this;
        }
    }

    public class FRigConnectorSettings : ITransferible
    {
        public FString Description;
        public EConnectorType Type;
        public FBool bOptional;
        public List<FRigConnectionRuleStash> Rules;

        [Location("void FRigConnectorSettings::Load(FArchive& Ar)")]
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Description);
            if (transfer.Supports.ConnectorsWithType)
            {
                Type = (EConnectorType)transfer.Move((byte)Type);
                transfer.Move(ref bOptional);
            }
            transfer.Move(ref Rules);
            return this;
        }
    }

    public class FRigSocketElement : FRigSingleParentElement
    {

        [Location("void FRigSocketElement::Load(FArchive& Ar, ESerializationPhase SerializationPhase)")]
        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            return this;
        }
    }

    public enum EConnectorType : uint8
    {
        Primary,
        Secondary,
    }

    public enum ESerializationPhase
    {
        StaticData,
        InterElementData
    }

    public enum ERigControlTransformChannel : byte
    {
        TranslationX,
        TranslationY,
        TranslationZ,
        Pitch,
        Yaw,
        Roll,
        ScaleX,
        ScaleY,
        ScaleZ
    }
}
