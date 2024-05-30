// <auto-generated />
using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Scaffolding;
using NetTopologySuite.Geometries;

#pragma warning disable 219, 612, 618
#nullable disable

namespace TestNamespace
{
    [EntityFrameworkInternal]
    public partial class PrincipalDerivedEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelTestBase+PrincipalDerived<Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelTestBase+DependentBase<byte?>>",
                typeof(CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>),
                baseEntityType,
                discriminatorValue: "PrincipalDerived<DependentBase<byte?>>",
                propertyCount: 0,
                navigationCount: 2,
                skipNavigationCount: 1,
                foreignKeyCount: 1);

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("Id"), declaringEntityType.FindProperty("AlternateId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id"), principalEntityType.FindProperty("AlternateId") }),
                principalEntityType,
                deleteBehavior: DeleteBehavior.Cascade,
                unique: true,
                required: true);

            return runtimeForeignKey;
        }

        public static RuntimeSkipNavigation CreateSkipNavigation1(RuntimeEntityType declaringEntityType, RuntimeEntityType targetEntityType, RuntimeEntityType joinEntityType)
        {
            var skipNavigation = declaringEntityType.AddSkipNavigation(
                "Principals",
                targetEntityType,
                joinEntityType.FindForeignKey(
                    new[] { joinEntityType.FindProperty("DerivedsId"), joinEntityType.FindProperty("DerivedsAlternateId") },
                    declaringEntityType.FindKey(new[] { declaringEntityType.FindProperty("Id"), declaringEntityType.FindProperty("AlternateId") }),
                    declaringEntityType),
                true,
                false,
                typeof(ICollection<CompiledModelTestBase.PrincipalBase>),
                propertyInfo: typeof(CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>).GetProperty("Principals", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>).GetField("<Principals>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var inverse = targetEntityType.FindSkipNavigation("Deriveds");
            if (inverse != null)
            {
                skipNavigation.Inverse = inverse;
                inverse.Inverse = skipNavigation;
            }

            skipNavigation.SetGetter(
                (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>> entity) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_PrincipalDerived1_Principals(entity),
                (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>> entity) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_PrincipalDerived1_Principals(entity) == null,
                (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>> instance) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_PrincipalDerived1_Principals(instance),
                (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>> instance) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_PrincipalDerived1_Principals(instance) == null);
            skipNavigation.SetSetter(
                (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>> entity, ICollection<CompiledModelTestBase.PrincipalBase> value) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_PrincipalDerived1_Principals(entity) = value);
            skipNavigation.SetMaterializationSetter(
                (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>> entity, ICollection<CompiledModelTestBase.PrincipalBase> value) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_PrincipalDerived1_Principals(entity) = value);
            skipNavigation.SetAccessors(
                (InternalEntityEntry entry) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_PrincipalDerived1_Principals((CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>>)entry.Entity),
                (InternalEntityEntry entry) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_PrincipalDerived1_Principals((CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>>)entry.Entity),
                null,
                (InternalEntityEntry entry) => entry.GetCurrentValue<ICollection<CompiledModelTestBase.PrincipalBase>>(skipNavigation),
                null);
            skipNavigation.SetPropertyIndexes(
                index: 4,
                originalValueIndex: -1,
                shadowIndex: -1,
                relationshipIndex: 6,
                storeGenerationIndex: -1);
            skipNavigation.SetCollectionAccessor<CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>, ICollection<CompiledModelTestBase.PrincipalBase>, CompiledModelTestBase.PrincipalBase>(
                (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>> entity) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_PrincipalDerived1_Principals(entity),
                (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>> entity, ICollection<CompiledModelTestBase.PrincipalBase> collection) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_PrincipalDerived1_Principals(entity) = (ICollection<CompiledModelTestBase.PrincipalBase>)collection,
                (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>> entity, ICollection<CompiledModelTestBase.PrincipalBase> collection) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_PrincipalDerived1_Principals(entity) = (ICollection<CompiledModelTestBase.PrincipalBase>)collection,
                (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>> entity, Action<CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>>, ICollection<CompiledModelTestBase.PrincipalBase>> setter) => ClrCollectionAccessorFactory.CreateAndSetHashSet<CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>>, ICollection<CompiledModelTestBase.PrincipalBase>, CompiledModelTestBase.PrincipalBase>(entity, setter),
                () => (ICollection<CompiledModelTestBase.PrincipalBase>)(ICollection<CompiledModelTestBase.PrincipalBase>)new HashSet<CompiledModelTestBase.PrincipalBase>(ReferenceEqualityComparer.Instance));
            skipNavigation.AddRuntimeAnnotation("UnsafeAccessors", new[] { ("PrincipalDerivedEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_PrincipalDerived1_Principals", "TestNamespace") });
            return skipNavigation;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            var id = runtimeEntityType.FindProperty("Id")!;
            var alternateId = runtimeEntityType.FindProperty("AlternateId")!;
            var enum1 = runtimeEntityType.FindProperty("Enum1")!;
            var enum2 = runtimeEntityType.FindProperty("Enum2")!;
            var flagsEnum1 = runtimeEntityType.FindProperty("FlagsEnum1")!;
            var flagsEnum2 = runtimeEntityType.FindProperty("FlagsEnum2")!;
            var point = runtimeEntityType.FindProperty("Point")!;
            var refTypeArray = runtimeEntityType.FindProperty("RefTypeArray")!;
            var refTypeEnumerable = runtimeEntityType.FindProperty("RefTypeEnumerable")!;
            var refTypeIList = runtimeEntityType.FindProperty("RefTypeIList")!;
            var refTypeList = runtimeEntityType.FindProperty("RefTypeList")!;
            var valueTypeArray = runtimeEntityType.FindProperty("ValueTypeArray")!;
            var valueTypeEnumerable = runtimeEntityType.FindProperty("ValueTypeEnumerable")!;
            var valueTypeIList = runtimeEntityType.FindProperty("ValueTypeIList")!;
            var valueTypeList = runtimeEntityType.FindProperty("ValueTypeList")!;
            var owned = runtimeEntityType.FindNavigation("Owned")!;
            var dependent = runtimeEntityType.FindNavigation("Dependent")!;
            var manyOwned = runtimeEntityType.FindNavigation("ManyOwned")!;
            runtimeEntityType.SetOriginalValuesFactory(
                (InternalEntityEntry source) =>
                {
                    var entity8 = (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>>)source.Entity;
                    return (ISnapshot)new Snapshot<Nullable<long>, Guid, CompiledModelTestBase.AnEnum, Nullable<CompiledModelTestBase.AnEnum>, CompiledModelTestBase.AFlagsEnum, CompiledModelTestBase.AFlagsEnum, Point, IPAddress[], IEnumerable<string>, IList<string>, List<IPAddress>, DateTime[], IEnumerable<byte>, IList<byte>, List<short>>(source.GetCurrentValue<Nullable<long>>(id) == null ? null : ((ValueComparer<Nullable<long>>)((IProperty)id).GetValueComparer()).Snapshot(source.GetCurrentValue<Nullable<long>>(id)), ((ValueComparer<Guid>)((IProperty)alternateId).GetValueComparer()).Snapshot(source.GetCurrentValue<Guid>(alternateId)), ((ValueComparer<CompiledModelTestBase.AnEnum>)((IProperty)enum1).GetValueComparer()).Snapshot(source.GetCurrentValue<CompiledModelTestBase.AnEnum>(enum1)), source.GetCurrentValue<Nullable<CompiledModelTestBase.AnEnum>>(enum2) == null ? null : ((ValueComparer<Nullable<CompiledModelTestBase.AnEnum>>)((IProperty)enum2).GetValueComparer()).Snapshot(source.GetCurrentValue<Nullable<CompiledModelTestBase.AnEnum>>(enum2)), ((ValueComparer<CompiledModelTestBase.AFlagsEnum>)((IProperty)flagsEnum1).GetValueComparer()).Snapshot(source.GetCurrentValue<CompiledModelTestBase.AFlagsEnum>(flagsEnum1)), ((ValueComparer<CompiledModelTestBase.AFlagsEnum>)((IProperty)flagsEnum2).GetValueComparer()).Snapshot(source.GetCurrentValue<CompiledModelTestBase.AFlagsEnum>(flagsEnum2)), source.GetCurrentValue<Point>(point) == null ? null : ((ValueComparer<Point>)((IProperty)point).GetValueComparer()).Snapshot(source.GetCurrentValue<Point>(point)), (object)source.GetCurrentValue<IPAddress[]>(refTypeArray) == null ? null : (IPAddress[])((ValueComparer<object>)((IProperty)refTypeArray).GetValueComparer()).Snapshot((object)source.GetCurrentValue<IPAddress[]>(refTypeArray)), (object)source.GetCurrentValue<IEnumerable<string>>(refTypeEnumerable) == null ? null : (IEnumerable<string>)((ValueComparer<object>)((IProperty)refTypeEnumerable).GetValueComparer()).Snapshot((object)source.GetCurrentValue<IEnumerable<string>>(refTypeEnumerable)), (object)source.GetCurrentValue<IList<string>>(refTypeIList) == null ? null : (IList<string>)((ValueComparer<object>)((IProperty)refTypeIList).GetValueComparer()).Snapshot((object)source.GetCurrentValue<IList<string>>(refTypeIList)), (object)source.GetCurrentValue<List<IPAddress>>(refTypeList) == null ? null : (List<IPAddress>)((ValueComparer<object>)((IProperty)refTypeList).GetValueComparer()).Snapshot((object)source.GetCurrentValue<List<IPAddress>>(refTypeList)), (IEnumerable<DateTime>)source.GetCurrentValue<DateTime[]>(valueTypeArray) == null ? null : (DateTime[])((ValueComparer<IEnumerable<DateTime>>)((IProperty)valueTypeArray).GetValueComparer()).Snapshot((IEnumerable<DateTime>)source.GetCurrentValue<DateTime[]>(valueTypeArray)), source.GetCurrentValue<IEnumerable<byte>>(valueTypeEnumerable) == null ? null : ((ValueComparer<IEnumerable<byte>>)((IProperty)valueTypeEnumerable).GetValueComparer()).Snapshot(source.GetCurrentValue<IEnumerable<byte>>(valueTypeEnumerable)), (IEnumerable<byte>)source.GetCurrentValue<IList<byte>>(valueTypeIList) == null ? null : (IList<byte>)((ValueComparer<IEnumerable<byte>>)((IProperty)valueTypeIList).GetValueComparer()).Snapshot((IEnumerable<byte>)source.GetCurrentValue<IList<byte>>(valueTypeIList)), (IEnumerable<short>)source.GetCurrentValue<List<short>>(valueTypeList) == null ? null : (List<short>)((ValueComparer<IEnumerable<short>>)((IProperty)valueTypeList).GetValueComparer()).Snapshot((IEnumerable<short>)source.GetCurrentValue<List<short>>(valueTypeList)));
                });
            runtimeEntityType.SetStoreGeneratedValuesFactory(
                () => (ISnapshot)new Snapshot<Nullable<long>, Guid, Point>(default(Nullable<long>) == null ? null : ((ValueComparer<Nullable<long>>)((IProperty)id).GetValueComparer()).Snapshot(default(Nullable<long>)), ((ValueComparer<Guid>)((IProperty)alternateId).GetValueComparer()).Snapshot(default(Guid)), default(Point) == null ? null : ((ValueComparer<Point>)((IProperty)point).GetValueComparer()).Snapshot(default(Point))));
            runtimeEntityType.SetTemporaryValuesFactory(
                (InternalEntityEntry source) => (ISnapshot)new Snapshot<Nullable<long>, Guid, Point>(default(Nullable<long>), default(Guid), default(Point)));
            runtimeEntityType.SetShadowValuesFactory(
                (IDictionary<string, object> source) => (ISnapshot)new Snapshot<Point>(source.ContainsKey("Point") ? (Point)source["Point"] : null));
            runtimeEntityType.SetEmptyShadowValuesFactory(
                () => (ISnapshot)new Snapshot<Point>(default(Point)));
            runtimeEntityType.SetRelationshipSnapshotFactory(
                (InternalEntityEntry source) =>
                {
                    var entity8 = (CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<Nullable<byte>>>)source.Entity;
                    return (ISnapshot)new Snapshot<Nullable<long>, Guid, object, object, object, object, object>(source.GetCurrentValue<Nullable<long>>(id) == null ? null : ((ValueComparer<Nullable<long>>)((IProperty)id).GetKeyValueComparer()).Snapshot(source.GetCurrentValue<Nullable<long>>(id)), ((ValueComparer<Guid>)((IProperty)alternateId).GetKeyValueComparer()).Snapshot(source.GetCurrentValue<Guid>(alternateId)), PrincipalBaseEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_PrincipalBase__ownedField(entity8), null, UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_PrincipalDerived1_Dependent(entity8), SnapshotFactoryFactory.SnapshotCollection(UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_PrincipalDerived1_ManyOwned(entity8)), null);
                });
            runtimeEntityType.Counts = new PropertyCounts(
                propertyCount: 15,
                navigationCount: 5,
                complexPropertyCount: 0,
                originalValueCount: 15,
                shadowCount: 1,
                relationshipCount: 7,
                storeGeneratedCount: 3);
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "PrincipalDerived");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<Principals>k__BackingField")]
        public static extern ref ICollection<CompiledModelTestBase.PrincipalBase> UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_PrincipalDerived1_Principals(CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>> @this);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<Dependent>k__BackingField")]
        public static extern ref CompiledModelTestBase.DependentBase<byte?> UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_PrincipalDerived1_Dependent(CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>> @this);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "ManyOwned")]
        public static extern ref ICollection<CompiledModelTestBase.OwnedType> UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_PrincipalDerived1_ManyOwned(CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>> @this);
    }
}
