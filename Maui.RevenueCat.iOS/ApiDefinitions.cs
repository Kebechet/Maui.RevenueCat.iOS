using System;
using Foundation;
using ObjCRuntime;
using ObjectiveC;
using RevenueCat;
using StoreKit;

[Static]
//[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern double RevenueCatVersionNumber;
	[Field ("RevenueCatVersionNumber", "__Internal")]
	double RevenueCatVersionNumber { get; }

	// extern const unsigned char[] RevenueCatVersionString;
	[Field ("RevenueCatVersionString", "__Internal")]
	byte[] RevenueCatVersionString { get; }
}

// @interface RCAttribution : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface RCAttribution
{
}

// @interface RevenueCat_Swift_3714 (RCAttribution)
//[NoWatch, NoTV, MacCatalyst (14,3), Mac (11,1), iOS (14,3)]
[Category]
[BaseType (typeof(RCAttribution))]
interface RCAttribution_RevenueCat_Swift_3714
{
	// -(void)enableAdServicesAttributionTokenCollection;
	[Export ("enableAdServicesAttributionTokenCollection")]
	void EnableAdServicesAttributionTokenCollection ();
}

// @interface RevenueCat_Swift_3723 (RCAttribution)
[Category]
[BaseType (typeof(RCAttribution))]
interface RCAttribution_RevenueCat_Swift_3723
{
	// -(void)collectDeviceIdentifiers;
	[Export ("collectDeviceIdentifiers")]
	void CollectDeviceIdentifiers ();

	// -(void)setAttributes:(NSDictionary<NSString *,NSString *> * _Nonnull)attributes;
	[Export ("setAttributes:")]
	void SetAttributes (NSDictionary<NSString, NSString> attributes);

	// -(void)setEmail:(NSString * _Nullable)email;
	[Export ("setEmail:")]
	void SetEmail ([NullAllowed] string email);

	// -(void)setPhoneNumber:(NSString * _Nullable)phoneNumber;
	[Export ("setPhoneNumber:")]
	void SetPhoneNumber ([NullAllowed] string phoneNumber);

	// -(void)setDisplayName:(NSString * _Nullable)displayName;
	[Export ("setDisplayName:")]
	void SetDisplayName ([NullAllowed] string displayName);

	// -(void)setPushToken:(NSData * _Nullable)pushToken;
	[Export ("setPushToken:")]
	void SetPushToken ([NullAllowed] NSData pushToken);

	// -(void)setPushTokenString:(NSString * _Nullable)pushToken;
	[Export ("setPushTokenString:")]
	void SetPushTokenString ([NullAllowed] string pushToken);

	// -(void)setAdjustID:(NSString * _Nullable)adjustID;
	[Export ("setAdjustID:")]
	void SetAdjustID ([NullAllowed] string adjustID);

	// -(void)setAppsflyerID:(NSString * _Nullable)appsflyerID;
	[Export ("setAppsflyerID:")]
	void SetAppsflyerID ([NullAllowed] string appsflyerID);

	// -(void)setFBAnonymousID:(NSString * _Nullable)fbAnonymousID;
	[Export ("setFBAnonymousID:")]
	void SetFBAnonymousID ([NullAllowed] string fbAnonymousID);

	// -(void)setMparticleID:(NSString * _Nullable)mparticleID;
	[Export ("setMparticleID:")]
	void SetMparticleID ([NullAllowed] string mparticleID);

	// -(void)setOnesignalID:(NSString * _Nullable)onesignalID;
	[Export ("setOnesignalID:")]
	void SetOnesignalID ([NullAllowed] string onesignalID);

	// -(void)setAirshipChannelID:(NSString * _Nullable)airshipChannelID;
	[Export ("setAirshipChannelID:")]
	void SetAirshipChannelID ([NullAllowed] string airshipChannelID);

	// -(void)setCleverTapID:(NSString * _Nullable)cleverTapID;
	[Export ("setCleverTapID:")]
	void SetCleverTapID ([NullAllowed] string cleverTapID);

	// -(void)setMixpanelDistinctID:(NSString * _Nullable)mixpanelDistinctID;
	[Export ("setMixpanelDistinctID:")]
	void SetMixpanelDistinctID ([NullAllowed] string mixpanelDistinctID);

	// -(void)setFirebaseAppInstanceID:(NSString * _Nullable)firebaseAppInstanceID;
	[Export ("setFirebaseAppInstanceID:")]
	void SetFirebaseAppInstanceID ([NullAllowed] string firebaseAppInstanceID);

	// -(void)setMediaSource:(NSString * _Nullable)mediaSource;
	[Export ("setMediaSource:")]
	void SetMediaSource ([NullAllowed] string mediaSource);

	// -(void)setCampaign:(NSString * _Nullable)campaign;
	[Export ("setCampaign:")]
	void SetCampaign ([NullAllowed] string campaign);

	// -(void)setAdGroup:(NSString * _Nullable)adGroup;
	[Export ("setAdGroup:")]
	void SetAdGroup ([NullAllowed] string adGroup);

	// -(void)setAd:(NSString * _Nullable)installAd;
	[Export ("setAd:")]
	void SetAd ([NullAllowed] string installAd);

	// -(void)setKeyword:(NSString * _Nullable)keyword;
	[Export ("setKeyword:")]
	void SetKeyword ([NullAllowed] string keyword);

	// -(void)setCreative:(NSString * _Nullable)creative;
	[Export ("setCreative:")]
	void SetCreative ([NullAllowed] string creative);
}

// @interface RCConfigurationBuilder : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface RCConfigurationBuilder
{
	// -(instancetype _Nonnull)initWithAPIKey:(NSString * _Nonnull)apiKey __attribute__((objc_designated_initializer));
	[Export ("initWithAPIKey:")]
	[DesignatedInitializer]
	NativeHandle Constructor (string apiKey);

	// -(RCConfigurationBuilder * _Nonnull)withApiKey:(NSString * _Nonnull)apiKey __attribute__((warn_unused_result("")));
	[Export ("withApiKey:")]
	RCConfigurationBuilder WithApiKey (string apiKey);

	// -(RCConfigurationBuilder * _Nonnull)withAppUserID:(NSString * _Nullable)appUserID __attribute__((warn_unused_result("")));
	[Export ("withAppUserID:")]
	RCConfigurationBuilder WithAppUserID ([NullAllowed] string appUserID);

	// -(RCConfigurationBuilder * _Nonnull)withObserverMode:(BOOL)observerMode __attribute__((warn_unused_result("")));
	[Export ("withObserverMode:")]
	RCConfigurationBuilder WithObserverMode (bool observerMode);

	// -(RCConfigurationBuilder * _Nonnull)withUserDefaults:(NSUserDefaults * _Nonnull)userDefaults __attribute__((warn_unused_result("")));
	[Export ("withUserDefaults:")]
	RCConfigurationBuilder WithUserDefaults (NSUserDefaults userDefaults);

	// -(RCConfigurationBuilder * _Nonnull)withDangerousSettings:(RCDangerousSettings * _Nonnull)dangerousSettings __attribute__((warn_unused_result("")));
	[Export ("withDangerousSettings:")]
	RCConfigurationBuilder WithDangerousSettings (RCDangerousSettings dangerousSettings);

	// -(RCConfigurationBuilder * _Nonnull)withNetworkTimeout:(NSTimeInterval)networkTimeout __attribute__((warn_unused_result("")));
	[Export ("withNetworkTimeout:")]
	RCConfigurationBuilder WithNetworkTimeout (double networkTimeout);

	// -(RCConfigurationBuilder * _Nonnull)withStoreKit1Timeout:(NSTimeInterval)storeKit1Timeout __attribute__((warn_unused_result("")));
	[Export ("withStoreKit1Timeout:")]
	RCConfigurationBuilder WithStoreKit1Timeout (double storeKit1Timeout);

	// -(RCConfigurationBuilder * _Nonnull)withPlatformInfo:(RCPlatformInfo * _Nonnull)platformInfo __attribute__((warn_unused_result("")));
	[Export ("withPlatformInfo:")]
	RCConfigurationBuilder WithPlatformInfo (RCPlatformInfo platformInfo);

	// -(RCConfigurationBuilder * _Nonnull)withEntitlementVerificationMode:(enum RCEntitlementVerificationMode)mode __attribute__((warn_unused_result(""))) __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6,2), TV (13,0), Mac (10,15), iOS (13,0)]
	[Export ("withEntitlementVerificationMode:")]
	RCConfigurationBuilder WithEntitlementVerificationMode (RCEntitlementVerificationMode mode);

	// -(RCConfiguration * _Nonnull)build __attribute__((warn_unused_result("")));
	[Export ("build")]
	//[Verify (MethodToProperty)]
	RCConfiguration Build { get; }
}

// @interface RevenueCat_Swift_4031 (RCConfigurationBuilder)
[Category]
[BaseType (typeof(RCConfigurationBuilder))]
interface RCConfigurationBuilder_RevenueCat_Swift_4031
{
	// -(RCConfigurationBuilder * _Nonnull)withUsesStoreKit2IfAvailable:(BOOL)usesStoreKit2IfAvailable __attribute__((warn_unused_result(""))) __attribute__((deprecated("
    RevenueCat currently uses StoreKit 1 for purchases, as its stability in production scenarios has
    proven to be more performant than StoreKit 2.

    We're collecting more data on the best approach, but StoreKit 1 vs StoreKit 2 is an implementation detail
    that you shouldn't need to care about.

    Simply remove this method call to let RevenueCat decide for you which StoreKit implementation to use.
    ")));
	[Export ("withUsesStoreKit2IfAvailable:")]
	RCConfigurationBuilder WithUsesStoreKit2IfAvailable (bool usesStoreKit2IfAvailable);
}

// @interface NetworkOperation : NSOperation
[BaseType (typeof(NSOperation), Name = "_TtC10RevenueCat16NetworkOperation")]
[DisableDefaultCtor]
interface NetworkOperation
{
	// @property (readonly, getter = isExecuting, nonatomic) BOOL executing;
	[Export ("executing")]
	bool Executing { [Bind ("isExecuting")] get; }

	// @property (readonly, getter = isFinished, nonatomic) BOOL finished;
	[Export ("finished")]
	bool Finished { [Bind ("isFinished")] get; }

	// @property (readonly, getter = isCancelled, nonatomic) BOOL cancelled;
	[Export ("cancelled")]
	bool Cancelled { [Bind ("isCancelled")] get; }

	// -(void)main;
	[Export ("main")]
	void Main ();

	// -(void)cancel;
	[Export ("cancel")]
	void Cancel ();

	// @property (readonly, getter = isAsynchronous, nonatomic) BOOL asynchronous;
	[Export ("asynchronous")]
	bool Asynchronous { [Bind ("isAsynchronous")] get; }
}

// @interface CacheableNetworkOperation : NetworkOperation
[BaseType (typeof(NetworkOperation), Name = "_TtC10RevenueCat25CacheableNetworkOperation")]
interface CacheableNetworkOperation
{
}

// @interface RCConfiguration : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface RCConfiguration
{
	// +(RCConfigurationBuilder * _Nonnull)builderWithAPIKey:(NSString * _Nonnull)apiKey __attribute__((warn_unused_result("")));
	[Static]
	[Export ("builderWithAPIKey:")]
	RCConfigurationBuilder BuilderWithAPIKey (string apiKey);
}

// @interface RevenueCat_Swift_4114 (RCConfiguration)
[Category]
[BaseType (typeof(RCConfiguration))]
interface RCConfiguration_RevenueCat_Swift_4114
{
}

// @interface RCCustomerInfo : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface RCCustomerInfo
{
	// @property (readonly, nonatomic, strong) RCEntitlementInfos * _Nonnull entitlements;
	[Export ("entitlements", ArgumentSemantic.Strong)]
	RCEntitlementInfos Entitlements { get; }

	// @property (readonly, copy, nonatomic) NSSet<NSString *> * _Nonnull activeSubscriptions;
	[Export ("activeSubscriptions", ArgumentSemantic.Copy)]
	NSSet<NSString> ActiveSubscriptions { get; }

	// @property (readonly, copy, nonatomic) NSSet<NSString *> * _Nonnull allPurchasedProductIdentifiers;
	[Export ("allPurchasedProductIdentifiers", ArgumentSemantic.Copy)]
	NSSet<NSString> AllPurchasedProductIdentifiers { get; }

	// @property (readonly, copy, nonatomic) NSDate * _Nullable latestExpirationDate;
	[NullAllowed, Export ("latestExpirationDate", ArgumentSemantic.Copy)]
	NSDate LatestExpirationDate { get; }

	// @property (readonly, copy, nonatomic) NSArray<RCNonSubscriptionTransaction *> * _Nonnull nonSubscriptions;
	[Export ("nonSubscriptions", ArgumentSemantic.Copy)]
	RCNonSubscriptionTransaction[] NonSubscriptions { get; }

	// @property (readonly, copy, nonatomic) NSDate * _Nonnull requestDate;
	[Export ("requestDate", ArgumentSemantic.Copy)]
	NSDate RequestDate { get; }

	// @property (readonly, copy, nonatomic) NSDate * _Nonnull firstSeen;
	[Export ("firstSeen", ArgumentSemantic.Copy)]
	NSDate FirstSeen { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull originalAppUserId;
	[Export ("originalAppUserId")]
	string OriginalAppUserId { get; }

	// @property (readonly, copy, nonatomic) NSURL * _Nullable managementURL;
	[NullAllowed, Export ("managementURL", ArgumentSemantic.Copy)]
	NSUrl ManagementURL { get; }

	// @property (readonly, copy, nonatomic) NSDate * _Nullable originalPurchaseDate;
	[NullAllowed, Export ("originalPurchaseDate", ArgumentSemantic.Copy)]
	NSDate OriginalPurchaseDate { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nullable originalApplicationVersion;
	[NullAllowed, Export ("originalApplicationVersion")]
	string OriginalApplicationVersion { get; }

	// -(NSDate * _Nullable)expirationDateForProductIdentifier:(NSString * _Nonnull)productIdentifier __attribute__((warn_unused_result("")));
	[Export ("expirationDateForProductIdentifier:")]
	[return: NullAllowed]
	NSDate ExpirationDateForProductIdentifier (string productIdentifier);

	// -(NSDate * _Nullable)purchaseDateForProductIdentifier:(NSString * _Nonnull)productIdentifier __attribute__((warn_unused_result("")));
	[Export ("purchaseDateForProductIdentifier:")]
	[return: NullAllowed]
	NSDate PurchaseDateForProductIdentifier (string productIdentifier);

	// -(NSDate * _Nullable)expirationDateForEntitlement:(NSString * _Nonnull)entitlementIdentifier __attribute__((warn_unused_result("")));
	[Export ("expirationDateForEntitlement:")]
	[return: NullAllowed]
	NSDate ExpirationDateForEntitlement (string entitlementIdentifier);

	// -(NSDate * _Nullable)purchaseDateForEntitlement:(NSString * _Nonnull)entitlementIdentifier __attribute__((warn_unused_result("")));
	[Export ("purchaseDateForEntitlement:")]
	[return: NullAllowed]
	NSDate PurchaseDateForEntitlement (string entitlementIdentifier);

	// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
	[Export ("isEqual:")]
	bool IsEqual ([NullAllowed] NSObject @object);

	// @property (readonly, nonatomic) NSUInteger hash;
	[Export ("hash")]
	nuint Hash { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
	[Export ("description")]
	string Description { get; }
}

// @interface RevenueCat_Swift_4242 (RCCustomerInfo)
[Category]
[BaseType (typeof(RCCustomerInfo))]
interface RCCustomerInfo_RevenueCat_Swift_4242
{
	// @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nonnull rawData;
	[Export ("rawData", ArgumentSemantic.Copy)]
	NSDictionary<NSString, NSObject> RawData { get; }
}

// @interface RevenueCat_Swift_4248 (RCCustomerInfo)
[Category]
[BaseType (typeof(RCCustomerInfo))]
interface RCCustomerInfo_RevenueCat_Swift_4248
{
	// @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("use nonSubscriptionTransactions") NSSet<NSString *> * nonConsumablePurchases __attribute__((deprecated("use nonSubscriptionTransactions")));
	[Export ("nonConsumablePurchases", ArgumentSemantic.Copy)]
	NSSet<NSString> NonConsumablePurchases { get; }

	// @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("", "nonSubscriptions") NSArray<RCStoreTransaction *> * nonSubscriptionTransactions __attribute__((deprecated("", "nonSubscriptions")));
	[Export ("nonSubscriptionTransactions", ArgumentSemantic.Copy)]
	RCStoreTransaction[] NonSubscriptionTransactions { get; }
}

// @interface RCDangerousSettings : NSObject
[BaseType (typeof(NSObject))]
interface RCDangerousSettings
{
	// @property (readonly, nonatomic) BOOL autoSyncPurchases;
	[Export ("autoSyncPurchases")]
	bool AutoSyncPurchases { get; }

	// @property (readonly, nonatomic) BOOL customEntitlementComputation;
	[Export ("customEntitlementComputation")]
	bool CustomEntitlementComputation { get; }

	// -(instancetype _Nonnull)initWithAutoSyncPurchases:(BOOL)autoSyncPurchases;
	[Export ("initWithAutoSyncPurchases:")]
	NativeHandle Constructor (bool autoSyncPurchases);

	// -(instancetype _Nonnull)initWithAutoSyncPurchases:(BOOL)autoSyncPurchases customEntitlementComputation:(BOOL)customEntitlementComputation;
	[Export ("initWithAutoSyncPurchases:customEntitlementComputation:")]
	NativeHandle Constructor (bool autoSyncPurchases, bool customEntitlementComputation);
}

// @interface RCEntitlementInfo : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface RCEntitlementInfo
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
	[Export ("identifier")]
	string Identifier { get; }

	// @property (readonly, nonatomic) BOOL isActive;
	[Export ("isActive")]
	bool IsActive { get; }

	// @property (readonly, nonatomic) BOOL willRenew;
	[Export ("willRenew")]
	bool WillRenew { get; }

	// @property (readonly, nonatomic) enum RCPeriodType periodType;
	[Export ("periodType")]
	RCPeriodType PeriodType { get; }

	// @property (readonly, copy, nonatomic) NSDate * _Nullable latestPurchaseDate;
	[NullAllowed, Export ("latestPurchaseDate", ArgumentSemantic.Copy)]
	NSDate LatestPurchaseDate { get; }

	// @property (readonly, copy, nonatomic) NSDate * _Nullable originalPurchaseDate;
	[NullAllowed, Export ("originalPurchaseDate", ArgumentSemantic.Copy)]
	NSDate OriginalPurchaseDate { get; }

	// @property (readonly, copy, nonatomic) NSDate * _Nullable expirationDate;
	[NullAllowed, Export ("expirationDate", ArgumentSemantic.Copy)]
	NSDate ExpirationDate { get; }

	// @property (readonly, nonatomic) enum RCStore store;
	[Export ("store")]
	RCStore Store { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull productIdentifier;
	[Export ("productIdentifier")]
	string ProductIdentifier { get; }

	// @property (readonly, nonatomic) BOOL isSandbox;
	[Export ("isSandbox")]
	bool IsSandbox { get; }

	// @property (readonly, copy, nonatomic) NSDate * _Nullable unsubscribeDetectedAt;
	[NullAllowed, Export ("unsubscribeDetectedAt", ArgumentSemantic.Copy)]
	NSDate UnsubscribeDetectedAt { get; }

	// @property (readonly, copy, nonatomic) NSDate * _Nullable billingIssueDetectedAt;
	[NullAllowed, Export ("billingIssueDetectedAt", ArgumentSemantic.Copy)]
	NSDate BillingIssueDetectedAt { get; }

	// @property (readonly, nonatomic) enum RCPurchaseOwnershipType ownershipType;
	[Export ("ownershipType")]
	RCPurchaseOwnershipType OwnershipType { get; }

	// @property (readonly, nonatomic) enum RCVerificationResult verification __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6, 2), TV (13, 0), Mac (10, 15), iOS (13, 0)]
	[Export ("verification")]
	RCVerificationResult Verification { get; }

	// @property (readonly, copy, nonatomic) NSDictionary<NSString *,id> * _Nonnull rawData;
	[Export ("rawData", ArgumentSemantic.Copy)]
	NSDictionary<NSString, NSObject> RawData { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
	[Export ("description")]
	string Description { get; }

	// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
	[Export ("isEqual:")]
	bool IsEqual ([NullAllowed] NSObject @object);

	// @property (readonly, nonatomic) NSUInteger hash;
	[Export ("hash")]
	nuint Hash { get; }
}

// @interface RevenueCat_Swift_4375 (RCEntitlementInfo)
[Category]
[BaseType (typeof(RCEntitlementInfo))]
interface RCEntitlementInfo_RevenueCat_Swift_4375
{
	// @property (readonly, nonatomic) BOOL isActiveInCurrentEnvironment;
	[Export ("isActiveInCurrentEnvironment")]
	bool IsActiveInCurrentEnvironment { get; }

	// @property (readonly, nonatomic) BOOL isActiveInAnyEnvironment;
	[Export ("isActiveInAnyEnvironment")]
	bool IsActiveInAnyEnvironment { get; }
}

// @interface RCEntitlementInfos : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface RCEntitlementInfos
{
	// @property (readonly, copy, nonatomic) NSDictionary<NSString *,RCEntitlementInfo *> * _Nonnull all;
	[Export ("all", ArgumentSemantic.Copy)]
	NSDictionary<NSString, RCEntitlementInfo> All { get; }

	// -(RCEntitlementInfo * _Nullable)objectForKeyedSubscript:(NSString * _Nonnull)key __attribute__((warn_unused_result("")));
	[Export ("objectForKeyedSubscript:")]
	[return: NullAllowed]
	RCEntitlementInfo ObjectForKeyedSubscript (string key);

	// @property (readonly, nonatomic) enum RCVerificationResult verification __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6, 2), TV (13, 0), Mac (10, 15), iOS (13, 0)]
	[Export ("verification")]
	RCVerificationResult Verification { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
	[Export ("description")]
	string Description { get; }

	// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
	[Export ("isEqual:")]
	bool IsEqual ([NullAllowed] NSObject @object);
}

// @interface RevenueCat_Swift_4416 (RCEntitlementInfos)
[Category]
[BaseType (typeof(RCEntitlementInfos))]
interface RCEntitlementInfos_RevenueCat_Swift_4416
{
	// @property (readonly, copy, nonatomic) NSDictionary<NSString *,RCEntitlementInfo *> * _Nonnull active;
	[Export ("active", ArgumentSemantic.Copy)]
	NSDictionary<NSString, RCEntitlementInfo> Active { get; }

	// @property (readonly, copy, nonatomic) NSDictionary<NSString *,RCEntitlementInfo *> * _Nonnull activeInCurrentEnvironment;
	[Export ("activeInCurrentEnvironment", ArgumentSemantic.Copy)]
	NSDictionary<NSString, RCEntitlementInfo> ActiveInCurrentEnvironment { get; }

	// @property (readonly, copy, nonatomic) NSDictionary<NSString *,RCEntitlementInfo *> * _Nonnull activeInAnyEnvironment;
	[Export ("activeInAnyEnvironment", ArgumentSemantic.Copy)]
	NSDictionary<NSString, RCEntitlementInfo> ActiveInAnyEnvironment { get; }
}

// @interface FakeASIdManager : NSObject
[BaseType (typeof(NSObject), Name = "_TtC10RevenueCat15FakeASIdManager")]
interface FakeASIdManager
{
	// +(FakeASIdManager * _Nonnull)sharedManager __attribute__((warn_unused_result("")));
	[Static]
	[Export ("sharedManager")]
	//[Verify (MethodToProperty)]
	FakeASIdManager SharedManager { get; }
}

// @interface FakeAfficheClient : NSObject
[BaseType (typeof(NSObject), Name = "_TtC10RevenueCat17FakeAfficheClient")]
interface FakeAfficheClient
{
	// +(FakeAfficheClient * _Nonnull)sharedClient __attribute__((warn_unused_result("")));
	[Static]
	[Export ("sharedClient")]
	//[Verify (MethodToProperty)]
	FakeAfficheClient SharedClient { get; }

	// -(void)requestAttributionDetailsWithBlock:(void (^ _Nonnull)(NSDictionary<NSString *,NSObject *> * _Nullable, NSError * _Nullable))completionHandler;
	[Export ("requestAttributionDetailsWithBlock:")]
	void RequestAttributionDetailsWithBlock (Action<NSDictionary<NSString, NSObject>, NSError> completionHandler);
}

// @interface FakeTrackingManager : NSObject
[BaseType (typeof(NSObject), Name = "_TtC10RevenueCat19FakeTrackingManager")]
interface FakeTrackingManager
{
	// +(NSInteger)trackingAuthorizationStatus __attribute__((warn_unused_result("")));
	[Static]
	[Export ("trackingAuthorizationStatus")]
	//[Verify (MethodToProperty)]
	nint TrackingAuthorizationStatus { get; }
}

// @interface GetCustomerInfoOperation : CacheableNetworkOperation
[BaseType (typeof(CacheableNetworkOperation), Name = "_TtC10RevenueCat24GetCustomerInfoOperation")]
interface GetCustomerInfoOperation
{
}

// @interface GetIntroEligibilityOperation : NetworkOperation
[BaseType (typeof(NetworkOperation), Name = "_TtC10RevenueCat28GetIntroEligibilityOperation")]
interface GetIntroEligibilityOperation
{
}

// @interface GetOfferingsOperation : CacheableNetworkOperation
[BaseType (typeof(CacheableNetworkOperation), Name = "_TtC10RevenueCat21GetOfferingsOperation")]
interface GetOfferingsOperation
{
}

// @interface GetProductEntitlementMappingOperation : CacheableNetworkOperation
[BaseType (typeof(CacheableNetworkOperation), Name = "_TtC10RevenueCat37GetProductEntitlementMappingOperation")]
interface GetProductEntitlementMappingOperation
{
}

// @interface RCIntroEligibility : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface RCIntroEligibility
{
	// @property (readonly, nonatomic) enum RCIntroEligibilityStatus status;
	[Export ("status")]
	RCIntroEligibilityStatus Status { get; }
}

// @interface RevenueCat_Swift_4563 (RCIntroEligibility)
[Category]
[BaseType (typeof(RCIntroEligibility))]
interface RCIntroEligibility_RevenueCat_Swift_4563
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
	[Export ("description")]
	string Description { get; }
}

// @interface LogInOperation : CacheableNetworkOperation
[BaseType (typeof(CacheableNetworkOperation), Name = "_TtC10RevenueCat14LogInOperation")]
interface LogInOperation
{
}

// @interface RCNonSubscriptionTransaction : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface RCNonSubscriptionTransaction
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull productIdentifier;
	[Export ("productIdentifier")]
	string ProductIdentifier { get; }

	// @property (readonly, copy, nonatomic) NSDate * _Nonnull purchaseDate;
	[Export ("purchaseDate", ArgumentSemantic.Copy)]
	NSDate PurchaseDate { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull transactionIdentifier;
	[Export ("transactionIdentifier")]
	string TransactionIdentifier { get; }
}

// @interface RCOffering : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface RCOffering
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
	[Export ("identifier")]
	string Identifier { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull serverDescription;
	[Export ("serverDescription")]
	string ServerDescription { get; }

	// @property (readonly, copy, nonatomic) NSArray<RCPackage *> * _Nonnull availablePackages;
	[Export ("availablePackages", ArgumentSemantic.Copy)]
	RCPackage[] AvailablePackages { get; }

	// @property (readonly, nonatomic, strong) RCPackage * _Nullable lifetime;
	[NullAllowed, Export ("lifetime", ArgumentSemantic.Strong)]
	RCPackage Lifetime { get; }

	// @property (readonly, nonatomic, strong) RCPackage * _Nullable annual;
	[NullAllowed, Export ("annual", ArgumentSemantic.Strong)]
	RCPackage Annual { get; }

	// @property (readonly, nonatomic, strong) RCPackage * _Nullable sixMonth;
	[NullAllowed, Export ("sixMonth", ArgumentSemantic.Strong)]
	RCPackage SixMonth { get; }

	// @property (readonly, nonatomic, strong) RCPackage * _Nullable threeMonth;
	[NullAllowed, Export ("threeMonth", ArgumentSemantic.Strong)]
	RCPackage ThreeMonth { get; }

	// @property (readonly, nonatomic, strong) RCPackage * _Nullable twoMonth;
	[NullAllowed, Export ("twoMonth", ArgumentSemantic.Strong)]
	RCPackage TwoMonth { get; }

	// @property (readonly, nonatomic, strong) RCPackage * _Nullable monthly;
	[NullAllowed, Export ("monthly", ArgumentSemantic.Strong)]
	RCPackage Monthly { get; }

	// @property (readonly, nonatomic, strong) RCPackage * _Nullable weekly;
	[NullAllowed, Export ("weekly", ArgumentSemantic.Strong)]
	RCPackage Weekly { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
	[Export ("description")]
	string Description { get; }

	// -(RCPackage * _Nullable)packageWithIdentifier:(NSString * _Nullable)identifier __attribute__((warn_unused_result("")));
	[Export ("packageWithIdentifier:")]
	[return: NullAllowed]
	RCPackage PackageWithIdentifier ([NullAllowed] string identifier);

	// -(RCPackage * _Nullable)objectForKeyedSubscript:(NSString * _Nonnull)key __attribute__((warn_unused_result("")));
	[Export ("objectForKeyedSubscript:")]
	[return: NullAllowed]
	RCPackage ObjectForKeyedSubscript (string key);
}

// @interface RCOfferings : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface RCOfferings
{
	// @property (readonly, copy, nonatomic) NSDictionary<NSString *,RCOffering *> * _Nonnull all;
	[Export ("all", ArgumentSemantic.Copy)]
	NSDictionary<NSString, RCOffering> All { get; }

	// @property (readonly, nonatomic, strong) RCOffering * _Nullable current;
	[NullAllowed, Export ("current", ArgumentSemantic.Strong)]
	RCOffering Current { get; }

	// -(RCOffering * _Nullable)offeringWithIdentifier:(NSString * _Nullable)identifier __attribute__((warn_unused_result("")));
	[Export ("offeringWithIdentifier:")]
	[return: NullAllowed]
	RCOffering OfferingWithIdentifier ([NullAllowed] string identifier);

	// -(RCOffering * _Nullable)objectForKeyedSubscript:(NSString * _Nonnull)key __attribute__((warn_unused_result("")));
	[Export ("objectForKeyedSubscript:")]
	[return: NullAllowed]
	RCOffering ObjectForKeyedSubscript (string key);

	// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
	[Export ("description")]
	string Description { get; }
}

// @interface RCPackage : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface RCPackage
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
	[Export ("identifier")]
	string Identifier { get; }

	// @property (readonly, nonatomic) enum RCPackageType packageType;
	[Export ("packageType")]
	RCPackageType PackageType { get; }

	// @property (readonly, nonatomic, strong) RCStoreProduct * _Nonnull storeProduct;
	[Export ("storeProduct", ArgumentSemantic.Strong)]
	RCStoreProduct StoreProduct { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull offeringIdentifier;
	[Export ("offeringIdentifier")]
	string OfferingIdentifier { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull localizedPriceString;
	[Export ("localizedPriceString")]
	string LocalizedPriceString { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nullable localizedIntroductoryPriceString;
	[NullAllowed, Export ("localizedIntroductoryPriceString")]
	string LocalizedIntroductoryPriceString { get; }

	// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
	[Export ("isEqual:")]
	bool IsEqual ([NullAllowed] NSObject @object);

	// @property (readonly, nonatomic) NSUInteger hash;
	[Export ("hash")]
	nuint Hash { get; }
}

// @interface RevenueCat_Swift_4765 (RCPackage)
[Category]
[BaseType (typeof(RCPackage))]
interface RCPackage_RevenueCat_Swift_4765
{
	// +(NSString * _Nullable)stringFrom:(enum RCPackageType)packageType __attribute__((warn_unused_result("")));
	[Static]
	[Export ("stringFrom:")]
	[return: NullAllowed]
	string StringFrom (RCPackageType packageType);

	// +(enum RCPackageType)packageTypeFrom:(NSString * _Nonnull)string __attribute__((warn_unused_result("")));
	[Static]
	[Export ("packageTypeFrom:")]
	RCPackageType PackageTypeFrom (string @string);
}

// @interface RevenueCat_Swift_4782 (RCPackage)
[Category]
[BaseType (typeof(RCPackage))]
interface RCPackage_RevenueCat_Swift_4782
{
	// @property (readonly, nonatomic, strong) SWIFT_AVAILABILITY(maccatalyst,obsoleted=1,message="'product' has been renamed to 'storeProduct': Use StoreProduct instead") SKProduct * product __attribute__((availability(maccatalyst, obsoleted=1))) __attribute__((availability(macos, obsoleted=1))) __attribute__((availability(watchos, obsoleted=1))) __attribute__((availability(tvos, obsoleted=1))) __attribute__((availability(ios, obsoleted=1)));
	[Obsoleted (PlatformName.MacCatalyst, 1, 0, message: "'product' has been renamed to 'storeProduct': Use StoreProduct instead")]
	[Obsoleted (PlatformName.MacOSX, 1, 0, message: "'product' has been renamed to 'storeProduct': Use StoreProduct instead")]
	[Obsoleted (PlatformName.WatchOS, 1, 0, message: "'product' has been renamed to 'storeProduct': Use StoreProduct instead")]
	[Obsoleted (PlatformName.TvOS, 1, 0, message: "'product' has been renamed to 'storeProduct': Use StoreProduct instead")]
	[Obsoleted (PlatformName.iOS, 1, 0, message: "'product' has been renamed to 'storeProduct': Use StoreProduct instead")]
	[Export ("product", ArgumentSemantic.Strong)]
	SKProduct Product { get; }
}

// @protocol PaymentQueueWrapperType
/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol (Name = "_TtP10RevenueCat23PaymentQueueWrapperType_")]
interface PaymentQueueWrapperType
{
	// @required -(void)finishTransaction:(SKPaymentTransaction * _Nonnull)transaction completion:(void (^ _Nonnull)(void))completion;
	[Abstract]
	[Export ("finishTransaction:completion:")]
	void FinishTransaction (SKPaymentTransaction transaction, Action completion);

	// @required -(void)showPriceConsentIfNeeded __attribute__((availability(maccatalyst, introduced=13.4))) __attribute__((availability(ios, introduced=13.4)));
	//[MacCatalyst (13,4), iOS (13,4)]
	[Abstract]
	[Export ("showPriceConsentIfNeeded")]
	void ShowPriceConsentIfNeeded ();

	// @required -(void)presentCodeRedemptionSheet __attribute__((availability(maccatalyst, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(ios, introduced=14.0)));
	//[NoWatch, NoTV, NoMacCatalyst, NoMac, iOS (14,0)]
	[Abstract]
	[Export ("presentCodeRedemptionSheet")]
	void PresentCodeRedemptionSheet ();

	// @required @property (readonly, nonatomic, strong) RCStorefront * _Nullable currentStorefront;
	[Abstract]
	[NullAllowed, Export ("currentStorefront", ArgumentSemantic.Strong)]
	RCStorefront CurrentStorefront { get; }
}

// @interface PaymentQueueWrapper : NSObject <PaymentQueueWrapperType>
[BaseType (typeof(NSObject), Name = "_TtC10RevenueCat19PaymentQueueWrapper")]
[DisableDefaultCtor]
interface PaymentQueueWrapper : IPaymentQueueWrapperType
{
	// -(void)finishTransaction:(SKPaymentTransaction * _Nonnull)transaction completion:(void (^ _Nonnull)(void))completion;
	[Export ("finishTransaction:completion:")]
	void FinishTransaction (SKPaymentTransaction transaction, Action completion);

	// -(void)showPriceConsentIfNeeded __attribute__((availability(maccatalyst, introduced=13.4))) __attribute__((availability(ios, introduced=13.4)));
	//[MacCatalyst (13,4), iOS (13,4)]
	[Export ("showPriceConsentIfNeeded")]
	void ShowPriceConsentIfNeeded ();

	// -(void)presentCodeRedemptionSheet __attribute__((availability(ios, introduced=14.0)));
	//[iOS (14,0)]
	[Export ("presentCodeRedemptionSheet")]
	void PresentCodeRedemptionSheet ();

	// @property (readonly, nonatomic, strong) RCStorefront * _Nullable currentStorefront;
	[NullAllowed, Export ("currentStorefront", ArgumentSemantic.Strong)]
	RCStorefront CurrentStorefront { get; }
}

// @interface RevenueCat_Swift_4846 (PaymentQueueWrapper) <SKPaymentQueueDelegate>
[Category]
[BaseType (typeof(PaymentQueueWrapper))]
interface PaymentQueueWrapper_RevenueCat_Swift_4846 : ISKPaymentQueueDelegate
{
	// -(BOOL)paymentQueueShouldShowPriceConsent:(SKPaymentQueue * _Nonnull)paymentQueue __attribute__((warn_unused_result(""))) __attribute__((availability(maccatalyst, introduced=13.4))) __attribute__((availability(ios, introduced=13.4)));
	//[MacCatalyst (13,4), iOS (13,4)]
	[Export ("paymentQueueShouldShowPriceConsent:")]
	bool PaymentQueueShouldShowPriceConsent (SKPaymentQueue paymentQueue);
}

// @interface RevenueCat_Swift_4852 (PaymentQueueWrapper) <SKPaymentTransactionObserver>
[Category]
[BaseType (typeof(PaymentQueueWrapper))]
interface PaymentQueueWrapper_RevenueCat_Swift_4852 : ISKPaymentTransactionObserver
{
	// -(void)paymentQueue:(SKPaymentQueue * _Nonnull)queue updatedTransactions:(NSArray<SKPaymentTransaction *> * _Nonnull)transactions;
	[Export ("paymentQueue:updatedTransactions:")]
	void PaymentQueue (SKPaymentQueue queue, SKPaymentTransaction[] transactions);

	// -(BOOL)paymentQueue:(SKPaymentQueue * _Nonnull)queue shouldAddStorePayment:(SKPayment * _Nonnull)payment forProduct:(SKProduct * _Nonnull)product __attribute__((swift_name("paymentQueue(_:shouldAddStorePayment:for:)"))) __attribute__((warn_unused_result("")));
	[Export ("paymentQueue:shouldAddStorePayment:forProduct:")]
	bool PaymentQueue (SKPaymentQueue queue, SKPayment payment, SKProduct product);
}

// @interface PostAdServicesTokenOperation : NetworkOperation
[BaseType (typeof(NetworkOperation), Name = "_TtC10RevenueCat28PostAdServicesTokenOperation")]
interface PostAdServicesTokenOperation
{
}

// @interface PostAttributionDataOperation : NetworkOperation
[BaseType (typeof(NetworkOperation), Name = "_TtC10RevenueCat28PostAttributionDataOperation")]
interface PostAttributionDataOperation
{
}

// @interface PostOfferForSigningOperation : NetworkOperation
[BaseType (typeof(NetworkOperation), Name = "_TtC10RevenueCat28PostOfferForSigningOperation")]
interface PostOfferForSigningOperation
{
}

// @interface PostReceiptDataOperation : CacheableNetworkOperation
[BaseType (typeof(CacheableNetworkOperation), Name = "_TtC10RevenueCat24PostReceiptDataOperation")]
interface PostReceiptDataOperation
{
}

// @interface PostSubscriberAttributesOperation : NetworkOperation
[BaseType (typeof(NetworkOperation), Name = "_TtC10RevenueCat33PostSubscriberAttributesOperation")]
interface PostSubscriberAttributesOperation
{
}

// @interface ProductsFetcherSK1 : NSObject
[BaseType (typeof(NSObject), Name = "_TtC10RevenueCat18ProductsFetcherSK1")]
[DisableDefaultCtor]
interface ProductsFetcherSK1
{
}

// @interface RevenueCat_Swift_4913 (ProductsFetcherSK1) <SKProductsRequestDelegate>
[Category]
[BaseType (typeof(ProductsFetcherSK1))]
interface ProductsFetcherSK1_RevenueCat_Swift_4913 : ISKProductsRequestDelegate
{
	// -(void)productsRequest:(SKProductsRequest * _Nonnull)request didReceiveResponse:(SKProductsResponse * _Nonnull)response;
	[Export ("productsRequest:didReceiveResponse:")]
	void ProductsRequest (SKProductsRequest request, SKProductsResponse response);

	// -(void)requestDidFinish:(SKRequest * _Nonnull)request;
	[Export ("requestDidFinish:")]
	void RequestDidFinish (SKRequest request);

	// -(void)request:(SKRequest * _Nonnull)request didFailWithError:(NSError * _Nonnull)error;
	[Export ("request:didFailWithError:")]
	void Request (SKRequest request, NSError error);
}

// @interface ProductsManager : NSObject
[BaseType (typeof(NSObject), Name = "_TtC10RevenueCat15ProductsManager")]
[DisableDefaultCtor]
interface ProductsManager
{
}

// @interface RCPromotionalOffer : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface RCPromotionalOffer
{
	// @property (readonly, nonatomic, strong) RCStoreProductDiscount * _Nonnull discount;
	[Export ("discount", ArgumentSemantic.Strong)]
	RCStoreProductDiscount Discount { get; }

	// @property (readonly, nonatomic, strong) RCPromotionalOfferSignedData * _Nonnull signedData;
	[Export ("signedData", ArgumentSemantic.Strong)]
	RCPromotionalOfferSignedData SignedData { get; }
}

// @interface RevenueCat_Swift_4973 (RCPromotionalOffer)
[Category]
[BaseType (typeof(RCPromotionalOffer))]
interface RCPromotionalOffer_RevenueCat_Swift_4973
{
}

// @interface RCPromotionalOfferSignedData : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface RCPromotionalOfferSignedData
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
	[Export ("identifier")]
	string Identifier { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull keyIdentifier;
	[Export ("keyIdentifier")]
	string KeyIdentifier { get; }

	// @property (readonly, copy, nonatomic) NSUUID * _Nonnull nonce;
	[Export ("nonce", ArgumentSemantic.Copy)]
	NSUuid Nonce { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull signature;
	[Export ("signature")]
	string Signature { get; }

	// @property (readonly, nonatomic) NSInteger timestamp;
	[Export ("timestamp")]
	nint Timestamp { get; }

	// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
	[Export ("isEqual:")]
	bool IsEqual ([NullAllowed] NSObject @object);
}

// @interface RCPromotionalOfferEligibility : NSObject
[Obsoleted (PlatformName.MacCatalyst, 1, 0, message: "Use PromotionalOffer instead")]
[Obsoleted (PlatformName.MacOSX, 1, 0, message: "Use PromotionalOffer instead")]
[Obsoleted (PlatformName.WatchOS, 1, 0, message: "Use PromotionalOffer instead")]
[Obsoleted (PlatformName.TvOS, 1, 0, message: "Use PromotionalOffer instead")]
[Obsoleted (PlatformName.iOS, 1, 0, message: "Use PromotionalOffer instead")]
[BaseType (typeof(NSObject))]
interface RCPromotionalOfferEligibility
{
}

// @interface RCPurchaserInfo : NSObject
[Obsoleted (PlatformName.MacOSX, 1, 0, message: "'PurchaserInfo' has been renamed to 'RCCustomerInfo'")]
[Obsoleted (PlatformName.WatchOS, 1, 0, message: "'PurchaserInfo' has been renamed to 'RCCustomerInfo'")]
[Obsoleted (PlatformName.TvOS, 1, 0, message: "'PurchaserInfo' has been renamed to 'RCCustomerInfo'")]
[Obsoleted (PlatformName.iOS, 1, 0, message: "'PurchaserInfo' has been renamed to 'RCCustomerInfo'")]
[BaseType (typeof(NSObject))]
interface RCPurchaserInfo
{
}

// @protocol RCPurchasesType
/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
interface RCPurchasesType
{
	// @required @property (readonly, copy, nonatomic) NSString * _Nonnull appUserID;
	[Abstract]
	[Export ("appUserID")]
	string AppUserID { get; }

	// @required @property (readonly, nonatomic) BOOL isAnonymous;
	[Abstract]
	[Export ("isAnonymous")]
	bool IsAnonymous { get; }

	// @required @property (nonatomic) BOOL finishTransactions;
	[Abstract]
	[Export ("finishTransactions")]
	bool FinishTransactions { get; set; }

	[Wrap ("WeakDelegate"), Abstract]
	[NullAllowed]
	RCPurchasesDelegate Delegate { get; set; }

	// @required @property (nonatomic, strong) id<RCPurchasesDelegate> _Nullable delegate;
	[Abstract]
	[NullAllowed, Export ("delegate", ArgumentSemantic.Strong)]
	NSObject WeakDelegate { get; set; }

	// @required -(void)logIn:(NSString * _Nonnull)appUserID completion:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, BOOL, NSError * _Nullable))completion;
	[Abstract]
	[Export ("logIn:completion:")]
	void LogIn (string appUserID, Action<RCCustomerInfo, bool, NSError> completion);

	// @required -(void)logIn:(NSString * _Nonnull)appUserID completionHandler:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, BOOL, NSError * _Nullable))completionHandler __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6,2), TV (13,0), Mac (10,15), iOS (13,0)]
	[Abstract]
	[Export ("logIn:completionHandler:")]
	void LogIn (string appUserID, Action<RCCustomerInfo, bool, NSError> completionHandler);

	// @required -(void)logOutWithCompletion:(void (^ _Nullable)(RCCustomerInfo * _Nullable, NSError * _Nullable))completion;
	[Abstract]
	[Export ("logOutWithCompletion:")]
	void LogOutWithCompletion ([NullAllowed] Action<RCCustomerInfo, NSError> completion);

	// @required -(void)logOutWithCompletionHandler:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, NSError * _Nullable))completionHandler __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6,2), TV (13,0), Mac (10,15), iOS (13,0)]
	[Abstract]
	[Export ("logOutWithCompletionHandler:")]
	void LogOutWithCompletionHandler (Action<RCCustomerInfo, NSError> completionHandler);

	// @required -(void)getCustomerInfoWithCompletion:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, NSError * _Nullable))completion;
	[Abstract]
	[Export ("getCustomerInfoWithCompletion:")]
	void GetCustomerInfoWithCompletion (Action<RCCustomerInfo, NSError> completion);

	// @required -(void)getCustomerInfoWithFetchPolicy:(enum RCCacheFetchPolicy)fetchPolicy completion:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, NSError * _Nullable))completion;
	[Abstract]
	[Export ("getCustomerInfoWithFetchPolicy:completion:")]
	void GetCustomerInfoWithFetchPolicy (RCCacheFetchPolicy fetchPolicy, Action<RCCustomerInfo, NSError> completion);

	// @required -(void)customerInfoWithCompletionHandler:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, NSError * _Nullable))completionHandler __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6,2), TV (13,0), Mac (10,15), iOS (13,0)]
	[Abstract]
	[Export ("customerInfoWithCompletionHandler:")]
	void CustomerInfoWithCompletionHandler (Action<RCCustomerInfo, NSError> completionHandler);

	// @required -(void)customerInfoWithFetchPolicy:(enum RCCacheFetchPolicy)fetchPolicy completionHandler:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, NSError * _Nullable))completionHandler __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6,2), TV (13,0), Mac (10,15), iOS (13,0)]
	[Abstract]
	[Export ("customerInfoWithFetchPolicy:completionHandler:")]
	void CustomerInfoWithFetchPolicy (RCCacheFetchPolicy fetchPolicy, Action<RCCustomerInfo, NSError> completionHandler);

	// @required -(void)getOfferingsWithCompletion:(void (^ _Nonnull)(RCOfferings * _Nullable, NSError * _Nullable))completion;
	[Abstract]
	[Export ("getOfferingsWithCompletion:")]
	void GetOfferingsWithCompletion (Action<RCOfferings, NSError> completion);

	// @required -(void)offeringsWithCompletionHandler:(void (^ _Nonnull)(RCOfferings * _Nullable, NSError * _Nullable))completionHandler __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6,2), TV (13,0), Mac (10,15), iOS (13,0)]
	[Abstract]
	[Export ("offeringsWithCompletionHandler:")]
	void OfferingsWithCompletionHandler (Action<RCOfferings, NSError> completionHandler);

	// @required -(void)getProductsWithIdentifiers:(NSArray<NSString *> * _Nonnull)productIdentifiers completion:(void (^ _Nonnull)(NSArray<RCStoreProduct *> * _Nonnull))completion;
	[Abstract]
	[Export ("getProductsWithIdentifiers:completion:")]
	void GetProductsWithIdentifiers (string[] productIdentifiers, Action<NSArray<RCStoreProduct>> completion);

	// @required -(void)products:(NSArray<NSString *> * _Nonnull)productIdentifiers completionHandler:(void (^ _Nonnull)(NSArray<RCStoreProduct *> * _Nonnull))completionHandler __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6,2), TV (13,0), Mac (10,15), iOS (13,0)]
	[Abstract]
	[Export ("products:completionHandler:")]
	void Products (string[] productIdentifiers, Action<NSArray<RCStoreProduct>> completionHandler);

	// @required -(void)purchaseProduct:(RCStoreProduct * _Nonnull)product withCompletion:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, BOOL))completion;
	[Abstract]
	[Export ("purchaseProduct:withCompletion:")]
	void PurchaseProduct (RCStoreProduct product, Action<RCStoreTransaction, RCCustomerInfo, NSError, bool> completion);

	// @required -(void)purchaseWithProduct:(RCStoreProduct * _Nonnull)product completionHandler:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, BOOL, NSError * _Nullable))completionHandler __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6,2), TV (13,0), Mac (10,15), iOS (13,0)]
	[Abstract]
	[Export ("purchaseWithProduct:completionHandler:")]
	void PurchaseWithProduct (RCStoreProduct product, Action<RCStoreTransaction, RCCustomerInfo, bool, NSError> completionHandler);

	// @required -(void)purchasePackage:(RCPackage * _Nonnull)package withCompletion:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, BOOL))completion;
	[Abstract]
	[Export ("purchasePackage:withCompletion:")]
	void PurchasePackage (RCPackage package, Action<RCStoreTransaction, RCCustomerInfo, NSError, bool> completion);

	// @required -(void)purchaseWithPackage:(RCPackage * _Nonnull)package completionHandler:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, BOOL, NSError * _Nullable))completionHandler __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6,2), TV (13,0), Mac (10,15), iOS (13,0)]
	[Abstract]
	[Export ("purchaseWithPackage:completionHandler:")]
	void PurchaseWithPackage (RCPackage package, Action<RCStoreTransaction, RCCustomerInfo, bool, NSError> completionHandler);

	// @required -(void)restorePurchasesWithCompletion:(void (^ _Nullable)(RCCustomerInfo * _Nullable, NSError * _Nullable))completion;
	[Abstract]
	[Export ("restorePurchasesWithCompletion:")]
	void RestorePurchasesWithCompletion ([NullAllowed] Action<RCCustomerInfo, NSError> completion);

	// @required -(void)restorePurchasesWithCompletionHandler:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, NSError * _Nullable))completionHandler __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6,2), TV (13,0), Mac (10,15), iOS (13,0)]
	[Abstract]
	[Export ("restorePurchasesWithCompletionHandler:")]
	void RestorePurchasesWithCompletionHandler (Action<RCCustomerInfo, NSError> completionHandler);

	// @required -(void)syncPurchasesWithCompletion:(void (^ _Nullable)(RCCustomerInfo * _Nullable, NSError * _Nullable))completion;
	[Abstract]
	[Export ("syncPurchasesWithCompletion:")]
	void SyncPurchasesWithCompletion ([NullAllowed] Action<RCCustomerInfo, NSError> completion);

	// @required -(void)syncPurchasesWithCompletionHandler:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, NSError * _Nullable))completionHandler __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6,2), TV (13,0), Mac (10,15), iOS (13,0)]
	[Abstract]
	[Export ("syncPurchasesWithCompletionHandler:")]
	void SyncPurchasesWithCompletionHandler (Action<RCCustomerInfo, NSError> completionHandler);

	// @required -(void)purchaseProduct:(RCStoreProduct * _Nonnull)product withPromotionalOffer:(RCPromotionalOffer * _Nonnull)promotionalOffer completion:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, BOOL))completion __attribute__((availability(tvos, introduced=12.2))) __attribute__((availability(maccatalyst, introduced=13.0))) __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(macos, introduced=10.14.4))) __attribute__((availability(ios, introduced=12.2)));
	//[Watch (6,2), TV (12,2), MacCatalyst (13,0), Mac (10,14,4), iOS (12,2)]
	[Abstract]
	[Export ("purchaseProduct:withPromotionalOffer:completion:")]
	void PurchaseProduct (RCStoreProduct product, RCPromotionalOffer promotionalOffer, Action<RCStoreTransaction, RCCustomerInfo, NSError, bool> completion);

	// @required -(void)purchaseWithProduct:(RCStoreProduct * _Nonnull)product promotionalOffer:(RCPromotionalOffer * _Nonnull)promotionalOffer completionHandler:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, BOOL, NSError * _Nullable))completionHandler __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6,2), TV (13,0), Mac (10,15), iOS (13,0)]
	[Abstract]
	[Export ("purchaseWithProduct:promotionalOffer:completionHandler:")]
	void PurchaseWithProduct (RCStoreProduct product, RCPromotionalOffer promotionalOffer, Action<RCStoreTransaction, RCCustomerInfo, bool, NSError> completionHandler);

	// @required -(void)purchasePackage:(RCPackage * _Nonnull)package withPromotionalOffer:(RCPromotionalOffer * _Nonnull)promotionalOffer completion:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, BOOL))completion __attribute__((availability(tvos, introduced=12.2))) __attribute__((availability(maccatalyst, introduced=13.0))) __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(macos, introduced=10.14.4))) __attribute__((availability(ios, introduced=12.2)));
	//[Watch (6,2), TV (12,2), MacCatalyst (13,0), Mac (10,14,4), iOS (12,2)]
	[Abstract]
	[Export ("purchasePackage:withPromotionalOffer:completion:")]
	void PurchasePackage (RCPackage package, RCPromotionalOffer promotionalOffer, Action<RCStoreTransaction, RCCustomerInfo, NSError, bool> completion);

	// @required -(void)purchaseWithPackage:(RCPackage * _Nonnull)package promotionalOffer:(RCPromotionalOffer * _Nonnull)promotionalOffer completionHandler:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, BOOL, NSError * _Nullable))completionHandler __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6,2), TV (13,0), Mac (10,15), iOS (13,0)]
	[Abstract]
	[Export ("purchaseWithPackage:promotionalOffer:completionHandler:")]
	void PurchaseWithPackage (RCPackage package, RCPromotionalOffer promotionalOffer, Action<RCStoreTransaction, RCCustomerInfo, bool, NSError> completionHandler);

	// @required -(void)checkTrialOrIntroDiscountEligibility:(NSArray<NSString *> * _Nonnull)productIdentifiers completion:(void (^ _Nonnull)(NSDictionary<NSString *,RCIntroEligibility *> * _Nonnull))receiveEligibility;
	[Abstract]
	[Export ("checkTrialOrIntroDiscountEligibility:completion:")]
	void CheckTrialOrIntroDiscountEligibility (string[] productIdentifiers, Action<NSDictionary<NSString, RCIntroEligibility>> receiveEligibility);

	// @required -(void)checkTrialOrIntroDiscountEligibilityWithProductIdentifiers:(NSArray<NSString *> * _Nonnull)productIdentifiers completionHandler:(void (^ _Nonnull)(NSDictionary<NSString *,RCIntroEligibility *> * _Nonnull))completionHandler __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6,2), TV (13,0), Mac (10,15), iOS (13,0)]
	[Abstract]
	[Export ("checkTrialOrIntroDiscountEligibilityWithProductIdentifiers:completionHandler:")]
	void CheckTrialOrIntroDiscountEligibilityWithProductIdentifiers (string[] productIdentifiers, Action<NSDictionary<NSString, RCIntroEligibility>> completionHandler);

	// @required -(void)checkTrialOrIntroDiscountEligibilityForProduct:(RCStoreProduct * _Nonnull)product completion:(void (^ _Nonnull)(enum RCIntroEligibilityStatus))completion;
	[Abstract]
	[Export ("checkTrialOrIntroDiscountEligibilityForProduct:completion:")]
	void CheckTrialOrIntroDiscountEligibilityForProduct (RCStoreProduct product, Action<RCIntroEligibilityStatus> completion);

	// @required -(void)checkTrialOrIntroDiscountEligibilityWithProduct:(RCStoreProduct * _Nonnull)product completionHandler:(void (^ _Nonnull)(enum RCIntroEligibilityStatus))completionHandler __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6,2), TV (13,0), Mac (10,15), iOS (13,0)]
	[Abstract]
	[Export ("checkTrialOrIntroDiscountEligibilityWithProduct:completionHandler:")]
	void CheckTrialOrIntroDiscountEligibilityWithProduct (RCStoreProduct product, Action<RCIntroEligibilityStatus> completionHandler);

	// @required -(void)getPromotionalOfferForProductDiscount:(RCStoreProductDiscount * _Nonnull)discount withProduct:(RCStoreProduct * _Nonnull)product withCompletion:(void (^ _Nonnull)(RCPromotionalOffer * _Nullable, NSError * _Nullable))completion __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=12.2))) __attribute__((availability(maccatalyst, introduced=13.0))) __attribute__((availability(macos, introduced=10.14.4))) __attribute__((availability(ios, introduced=12.2)));
	//[Watch (6,2), TV (12,2), MacCatalyst (13,0), Mac (10,14,4), iOS (12,2)]
	[Abstract]
	[Export ("getPromotionalOfferForProductDiscount:withProduct:withCompletion:")]
	void GetPromotionalOfferForProductDiscount (RCStoreProductDiscount discount, RCStoreProduct product, Action<RCPromotionalOffer, NSError> completion);

	// @required -(void)promotionalOfferForProductDiscount:(RCStoreProductDiscount * _Nonnull)discount product:(RCStoreProduct * _Nonnull)product completionHandler:(void (^ _Nonnull)(RCPromotionalOffer * _Nullable, NSError * _Nullable))completionHandler __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6,2), TV (13,0), Mac (10,15), iOS (13,0)]
	[Abstract]
	[Export ("promotionalOfferForProductDiscount:product:completionHandler:")]
	void PromotionalOfferForProductDiscount (RCStoreProductDiscount discount, RCStoreProduct product, Action<RCPromotionalOffer, NSError> completionHandler);

	// @required -(void)eligiblePromotionalOffersForProduct:(RCStoreProduct * _Nonnull)product completionHandler:(void (^ _Nonnull)(NSArray<RCPromotionalOffer *> * _Nonnull))completionHandler __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6,2), TV (13,0), Mac (10,15), iOS (13,0)]
	[Abstract]
	[Export ("eligiblePromotionalOffersForProduct:completionHandler:")]
	void EligiblePromotionalOffersForProduct (RCStoreProduct product, Action<NSArray<RCPromotionalOffer>> completionHandler);

	// @required -(void)invalidateCustomerInfoCache;
	[Abstract]
	[Export ("invalidateCustomerInfoCache")]
	void InvalidateCustomerInfoCache ();

	// @required -(void)beginRefundRequestForProduct:(NSString * _Nonnull)productID completion:(void (^ _Nonnull)(enum RCRefundRequestStatus, NSError * _Nullable))completionHandler __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(ios, introduced=15.0)));
	//[NoWatch, NoTV, NoMac, iOS (15,0)]
	[Abstract]
	[Export ("beginRefundRequestForProduct:completion:")]
	void BeginRefundRequestForProduct (string productID, Action<RCRefundRequestStatus, NSError> completionHandler);

	// @required -(void)beginRefundRequestForEntitlement:(NSString * _Nonnull)entitlementID completion:(void (^ _Nonnull)(enum RCRefundRequestStatus, NSError * _Nullable))completionHandler __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(ios, introduced=15.0)));
	//[NoWatch, NoTV, NoMac, iOS (15,0)]
	[Abstract]
	[Export ("beginRefundRequestForEntitlement:completion:")]
	void BeginRefundRequestForEntitlement (string entitlementID, Action<RCRefundRequestStatus, NSError> completionHandler);

	// @required -(void)beginRefundRequestForActiveEntitlementWithCompletion:(void (^ _Nonnull)(enum RCRefundRequestStatus, NSError * _Nullable))completionHandler __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(ios, introduced=15.0)));
	//[NoWatch, NoTV, NoMac, iOS (15,0)]
	[Abstract]
	[Export ("beginRefundRequestForActiveEntitlementWithCompletion:")]
	void BeginRefundRequestForActiveEntitlementWithCompletion (Action<RCRefundRequestStatus, NSError> completionHandler);

	// @required -(void)presentCodeRedemptionSheet __attribute__((availability(maccatalyst, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(ios, introduced=14.0)));
	//[NoWatch, NoTV, NoMacCatalyst, NoMac, iOS (14,0)]
	[Abstract]
	[Export ("presentCodeRedemptionSheet")]
	void PresentCodeRedemptionSheet ();

	// @required -(void)showPriceConsentIfNeeded __attribute__((availability(maccatalyst, introduced=13.4))) __attribute__((availability(ios, introduced=13.4)));
	//[MacCatalyst (13,4), iOS (13,4)]
	[Abstract]
	[Export ("showPriceConsentIfNeeded")]
	void ShowPriceConsentIfNeeded ();

	// @required -(void)showManageSubscriptionsWithCompletion:(void (^ _Nonnull)(NSError * _Nullable))completion __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable)));
	//[NoWatch, NoTV, Mac (10,15), iOS (13,0)]
	[Abstract]
	[Export ("showManageSubscriptionsWithCompletion:")]
	void ShowManageSubscriptionsWithCompletion (Action<NSError> completion);

	// @required -(void)showManageSubscriptionsWithCompletionHandler:(void (^ _Nonnull)(NSError * _Nullable))completionHandler __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable)));
	//[NoWatch, NoTV, Mac (10,15), iOS (13,0)]
	[Abstract]
	[Export ("showManageSubscriptionsWithCompletionHandler:")]
	void ShowManageSubscriptionsWithCompletionHandler (Action<NSError> completionHandler);

	// @required @property (readonly, nonatomic, strong) RCAttribution * _Nonnull attribution;
	[Abstract]
	[Export ("attribution", ArgumentSemantic.Strong)]
	RCAttribution Attribution { get; }

	// @required -(void)setAttributes:(NSDictionary<NSString *,NSString *> * _Nonnull)attributes;
	[Abstract]
	[Export ("setAttributes:")]
	void SetAttributes (NSDictionary<NSString, NSString> attributes);

	// @required @property (nonatomic) BOOL allowSharingAppStoreAccount __attribute__((deprecated("")));
	[Abstract]
	[Export ("allowSharingAppStoreAccount")]
	bool AllowSharingAppStoreAccount { get; set; }

	// @required -(void)setEmail:(NSString * _Nullable)email __attribute__((deprecated("")));
	[Abstract]
	[Export ("setEmail:")]
	void SetEmail ([NullAllowed] string email);

	// @required -(void)setPhoneNumber:(NSString * _Nullable)phoneNumber __attribute__((deprecated("")));
	[Abstract]
	[Export ("setPhoneNumber:")]
	void SetPhoneNumber ([NullAllowed] string phoneNumber);

	// @required -(void)setDisplayName:(NSString * _Nullable)displayName __attribute__((deprecated("")));
	[Abstract]
	[Export ("setDisplayName:")]
	void SetDisplayName ([NullAllowed] string displayName);

	// @required -(void)setPushToken:(NSData * _Nullable)pushToken __attribute__((deprecated("")));
	[Abstract]
	[Export ("setPushToken:")]
	void SetPushToken ([NullAllowed] NSData pushToken);

	// @required -(void)setPushTokenString:(NSString * _Nullable)pushToken __attribute__((deprecated("")));
	[Abstract]
	[Export ("setPushTokenString:")]
	void SetPushTokenString ([NullAllowed] string pushToken);

	// @required -(void)setAdjustID:(NSString * _Nullable)adjustID __attribute__((deprecated("")));
	[Abstract]
	[Export ("setAdjustID:")]
	void SetAdjustID ([NullAllowed] string adjustID);

	// @required -(void)setAppsflyerID:(NSString * _Nullable)appsflyerID __attribute__((deprecated("")));
	[Abstract]
	[Export ("setAppsflyerID:")]
	void SetAppsflyerID ([NullAllowed] string appsflyerID);

	// @required -(void)setFBAnonymousID:(NSString * _Nullable)fbAnonymousID __attribute__((deprecated("")));
	[Abstract]
	[Export ("setFBAnonymousID:")]
	void SetFBAnonymousID ([NullAllowed] string fbAnonymousID);

	// @required -(void)setMparticleID:(NSString * _Nullable)mparticleID __attribute__((deprecated("")));
	[Abstract]
	[Export ("setMparticleID:")]
	void SetMparticleID ([NullAllowed] string mparticleID);

	// @required -(void)setOnesignalID:(NSString * _Nullable)onesignalID __attribute__((deprecated("")));
	[Abstract]
	[Export ("setOnesignalID:")]
	void SetOnesignalID ([NullAllowed] string onesignalID);

	// @required -(void)setMediaSource:(NSString * _Nullable)mediaSource __attribute__((deprecated("")));
	[Abstract]
	[Export ("setMediaSource:")]
	void SetMediaSource ([NullAllowed] string mediaSource);

	// @required -(void)setCampaign:(NSString * _Nullable)campaign __attribute__((deprecated("")));
	[Abstract]
	[Export ("setCampaign:")]
	void SetCampaign ([NullAllowed] string campaign);

	// @required -(void)setAdGroup:(NSString * _Nullable)adGroup __attribute__((deprecated("")));
	[Abstract]
	[Export ("setAdGroup:")]
	void SetAdGroup ([NullAllowed] string adGroup);

	// @required -(void)setAd:(NSString * _Nullable)value __attribute__((deprecated("")));
	[Abstract]
	[Export ("setAd:")]
	void SetAd ([NullAllowed] string value);

	// @required -(void)setKeyword:(NSString * _Nullable)keyword __attribute__((deprecated("")));
	[Abstract]
	[Export ("setKeyword:")]
	void SetKeyword ([NullAllowed] string keyword);

	// @required -(void)setCreative:(NSString * _Nullable)creative __attribute__((deprecated("")));
	[Abstract]
	[Export ("setCreative:")]
	void SetCreative ([NullAllowed] string creative);

	// @required -(void)setCleverTapID:(NSString * _Nullable)cleverTapID __attribute__((deprecated("")));
	[Abstract]
	[Export ("setCleverTapID:")]
	void SetCleverTapID ([NullAllowed] string cleverTapID);

	// @required -(void)setMixpanelDistinctID:(NSString * _Nullable)mixpanelDistinctID __attribute__((deprecated("")));
	[Abstract]
	[Export ("setMixpanelDistinctID:")]
	void SetMixpanelDistinctID ([NullAllowed] string mixpanelDistinctID);

	// @required -(void)setFirebaseAppInstanceID:(NSString * _Nullable)firebaseAppInstanceID __attribute__((deprecated("")));
	[Abstract]
	[Export ("setFirebaseAppInstanceID:")]
	void SetFirebaseAppInstanceID ([NullAllowed] string firebaseAppInstanceID);

	// @required -(void)collectDeviceIdentifiers __attribute__((deprecated("")));
	[Abstract]
	[Export ("collectDeviceIdentifiers")]
	void CollectDeviceIdentifiers ();
}

// @interface RCPurchases : NSObject <RCPurchasesType>
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface RCPurchases : IRCPurchasesType
{
	// @property (readonly, nonatomic, strong, class) RCPurchases * _Nonnull sharedPurchases;
	[Static]
	[Export ("sharedPurchases", ArgumentSemantic.Strong)]
	RCPurchases SharedPurchases { get; }

	// @property (readonly, nonatomic, class) BOOL isConfigured;
	[Static]
	[Export ("isConfigured")]
	bool IsConfigured { get; }

	[Wrap ("WeakDelegate")]
	[NullAllowed]
	RCPurchasesDelegate Delegate { get; set; }

	// @property (nonatomic, strong) id<RCPurchasesDelegate> _Nullable delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Strong)]
	NSObject WeakDelegate { get; set; }

	// @property (nonatomic, class) enum RCLogLevel logLevel;
	[Static]
	[Export ("logLevel", ArgumentSemantic.Assign)]
	RCLogLevel LogLevel { get; set; }

	// @property (copy, nonatomic, class) NSURL * _Nullable proxyURL;
	[Static]
	[NullAllowed, Export ("proxyURL", ArgumentSemantic.Copy)]
	NSUrl ProxyURL { get; set; }

	// @property (nonatomic, class) BOOL forceUniversalAppStore;
	[Static]
	[Export ("forceUniversalAppStore")]
	bool ForceUniversalAppStore { get; set; }

	// @property (nonatomic, class) BOOL simulatesAskToBuyInSandbox __attribute__((availability(maccatalyst, introduced=13.0))) __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(ios, introduced=8.0)));
	//[Watch (6, 2), MacCatalyst (13, 0), Mac (10, 14), iOS (8, 0)]
	[Static]
	[Export ("simulatesAskToBuyInSandbox")]
	bool SimulatesAskToBuyInSandbox { get; set; }

	// +(BOOL)canMakePayments __attribute__((warn_unused_result("")));
	[Static]
	[Export ("canMakePayments")]
	//[Verify (MethodToProperty)]
	bool CanMakePayments { get; }

	// @property (copy, nonatomic, class) void (^ _Nonnull)(enum RCLogLevel, NSString * _Nonnull) logHandler;
	[Static]
	[Export ("logHandler", ArgumentSemantic.Copy)]
	Action<RCLogLevel, NSString> LogHandler { get; set; }

	// @property (copy, nonatomic, class) void (^ _Nonnull)(enum RCLogLevel, NSString * _Nonnull, NSString * _Nullable, NSString * _Nullable, NSUInteger) verboseLogHandler;
	[Static]
	[Export ("verboseLogHandler", ArgumentSemantic.Copy)]
	Action<RCLogLevel, NSString, NSString, NSString, nuint> VerboseLogHandler { get; set; }

	// @property (nonatomic, class) BOOL verboseLogs;
	[Static]
	[Export ("verboseLogs")]
	bool VerboseLogs { get; set; }

	// @property (readonly, copy, nonatomic, class) NSString * _Nonnull frameworkVersion;
	[Static]
	[Export ("frameworkVersion")]
	string FrameworkVersion { get; }

	// @property (readonly, nonatomic, strong) RCAttribution * _Nonnull attribution;
	[Export ("attribution", ArgumentSemantic.Strong)]
	RCAttribution Attribution { get; }

	// @property (nonatomic) BOOL finishTransactions;
	[Export ("finishTransactions")]
	bool FinishTransactions { get; set; }
}

// @interface RevenueCat_Swift_5846 (RCPurchases)
[Category]
[BaseType (typeof(RCPurchases))]
interface RCPurchases_RevenueCat_Swift_5846
{
	// @property (nonatomic, strong, class) RCPlatformInfo * _Nullable platformInfo;
	[Static]
	[NullAllowed, Export ("platformInfo", ArgumentSemantic.Strong)]
	RCPlatformInfo PlatformInfo { get; set; }
}

// @interface RCPlatformInfo : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface RCPlatformInfo
{
	// -(instancetype _Nonnull)initWithFlavor:(NSString * _Nonnull)flavor version:(NSString * _Nonnull)version __attribute__((objc_designated_initializer));
	[Export ("initWithFlavor:version:")]
	[DesignatedInitializer]
	NativeHandle Constructor (string flavor, string version);
}

// @protocol PurchasesOrchestratorDelegate
[Protocol (Name = "_TtP10RevenueCat29PurchasesOrchestratorDelegate_"), Model/* (AutoGeneratedName = true)*/]
interface PurchasesOrchestratorDelegate
{
	// @required -(void)readyForPromotedProduct:(RCStoreProduct * _Nonnull)product purchase:(void (^ _Nonnull)(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, BOOL)))startPurchase;
	[Abstract]
	[Export ("readyForPromotedProduct:purchase:")]
	void Purchase (RCStoreProduct product, Action<Action<RCStoreTransaction, RCCustomerInfo, NSError, bool>> startPurchase);

	// @required @property (readonly, nonatomic) BOOL shouldShowPriceConsent __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(maccatalyst, introduced=13.4))) __attribute__((availability(ios, introduced=13.4)));
	//[NoWatch, NoTV, NoMac, MacCatalyst (13, 4), iOS (13, 4)]
	[Abstract]
	[Export ("shouldShowPriceConsent")]
	bool ShouldShowPriceConsent { get; }
}

// @interface RevenueCat_Swift_5870 (RCPurchases) <PurchasesOrchestratorDelegate>
[Category]
[BaseType (typeof(RCPurchases))]
interface RCPurchases_RevenueCat_Swift_5870 : IPurchasesOrchestratorDelegate
{
	// -(void)readyForPromotedProduct:(RCStoreProduct * _Nonnull)product purchase:(void (^ _Nonnull)(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, BOOL)))startPurchase;
	[Export ("readyForPromotedProduct:purchase:")]
	void ReadyForPromotedProduct (RCStoreProduct product, Action<Action<RCStoreTransaction, RCCustomerInfo, NSError, bool>> startPurchase);

	// @property (readonly, nonatomic) BOOL shouldShowPriceConsent __attribute__((availability(maccatalyst, introduced=13.4))) __attribute__((availability(ios, introduced=13.4)));
	//[MacCatalyst (13, 4), iOS (13, 4)]
	[Export ("shouldShowPriceConsent")]
	bool ShouldShowPriceConsent { get; }
}

// @interface RevenueCat_Swift_5891 (RCPurchases)
[Category]
[BaseType (typeof(RCPurchases))]
interface RCPurchases_RevenueCat_Swift_5891
{
	// -(void)logIn:(NSString * _Nonnull)appUserID completion:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, BOOL, NSError * _Nullable))completion;
	[Export ("logIn:completion:")]
	void LogIn (string appUserID, Action<RCCustomerInfo, bool, NSError> completion);

	// -(void)logIn:(NSString * _Nonnull)appUserID completionHandler:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, BOOL, NSError * _Nullable))completionHandler __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6,2), TV (13,0), Mac (10,15), iOS (13,0)]
	[Export ("logIn:completionHandler:")]
	void LogIn (string appUserID, Action<RCCustomerInfo, bool, NSError> completionHandler);

	// -(void)logOutWithCompletion:(void (^ _Nullable)(RCCustomerInfo * _Nullable, NSError * _Nullable))completion;
	[Export ("logOutWithCompletion:")]
	void LogOutWithCompletion ([NullAllowed] Action<RCCustomerInfo, NSError> completion);

	// -(void)logOutWithCompletionHandler:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, NSError * _Nullable))completionHandler __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6,2), TV (13,0), Mac (10,15), iOS (13,0)]
	[Export ("logOutWithCompletionHandler:")]
	void LogOutWithCompletionHandler (Action<RCCustomerInfo, NSError> completionHandler);
}

// @interface RevenueCat_Swift_5899 (RCPurchases)
[Category]
[BaseType (typeof(RCPurchases))]
interface RCPurchases_RevenueCat_Swift_5899
{
	// +(RCPurchases * _Nonnull)configureWithConfiguration:(RCConfiguration * _Nonnull)configuration;
	[Static]
	[Export ("configureWithConfiguration:")]
	RCPurchases ConfigureWithConfiguration (RCConfiguration configuration);

	// +(RCPurchases * _Nonnull)configureWithConfigurationBuilder:(RCConfigurationBuilder * _Nonnull)builder;
	[Static]
	[Export ("configureWithConfigurationBuilder:")]
	RCPurchases ConfigureWithConfigurationBuilder (RCConfigurationBuilder builder);

	// +(RCPurchases * _Nonnull)configureWithAPIKey:(NSString * _Nonnull)apiKey;
	[Static]
	[Export ("configureWithAPIKey:")]
	RCPurchases ConfigureWithAPIKey (string apiKey);

	// +(RCPurchases * _Nonnull)configureWithAPIKey:(NSString * _Nonnull)apiKey appUserID:(NSString * _Nullable)appUserID;
	[Static]
	[Export ("configureWithAPIKey:appUserID:")]
	RCPurchases ConfigureWithAPIKey (string apiKey, [NullAllowed] string appUserID);

	// +(RCPurchases * _Nonnull)configureWithAPIKey:(NSString * _Nonnull)apiKey appUserID:(NSString * _Nullable)appUserID observerMode:(BOOL)observerMode;
	[Static]
	[Export ("configureWithAPIKey:appUserID:observerMode:")]
	RCPurchases ConfigureWithAPIKey (string apiKey, [NullAllowed] string appUserID, bool observerMode);
}

// @interface RevenueCat_Swift_5990 (RCPurchases)
[Category]
[BaseType (typeof(RCPurchases))]
interface RCPurchases_RevenueCat_Swift_5990
{
	// @property (nonatomic, class) BOOL debugLogsEnabled __attribute__((deprecated("use Purchases.logLevel instead")));
	[Static]
	[Export ("debugLogsEnabled")]
	bool DebugLogsEnabled { get; set; }

	// @property (nonatomic) BOOL allowSharingAppStoreAccount __attribute__((deprecated("Configure behavior through the RevenueCat dashboard instead")));
	[Export ("allowSharingAppStoreAccount")]
	bool AllowSharingAppStoreAccount { get; set; }

	// +(void)addAttributionData:(NSDictionary<NSString *,id> * _Nonnull)data fromNetwork:(enum RCAttributionNetwork)network __attribute__((deprecated("Use the set<NetworkId> functions instead")));
	[Static]
	[Export ("addAttributionData:fromNetwork:")]
	void AddAttributionData (NSDictionary<NSString, NSObject> data, RCAttributionNetwork network);

	// +(void)addAttributionData:(NSDictionary<NSString *,id> * _Nonnull)data fromNetwork:(enum RCAttributionNetwork)network forNetworkUserId:(NSString * _Nullable)networkUserId __attribute__((deprecated("Use the set<NetworkId> functions instead")));
	[Static]
	[Export ("addAttributionData:fromNetwork:forNetworkUserId:")]
	void AddAttributionData (NSDictionary<NSString, NSObject> data, RCAttributionNetwork network, [NullAllowed] string networkUserId);
}

// @interface RevenueCat_Swift_6017 (RCPurchases)
[Category]
[BaseType (typeof(RCPurchases))]
interface RCPurchases_RevenueCat_Swift_6017
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull appUserID;
	[Export ("appUserID")]
	string AppUserID { get; }

	// @property (readonly, nonatomic) BOOL isAnonymous;
	[Export ("isAnonymous")]
	bool IsAnonymous { get; }

	// -(void)getOfferingsWithCompletion:(void (^ _Nonnull)(RCOfferings * _Nullable, NSError * _Nullable))completion;
	[Export ("getOfferingsWithCompletion:")]
	void GetOfferingsWithCompletion (Action<RCOfferings, NSError> completion);

	// -(void)offeringsWithCompletionHandler:(void (^ _Nonnull)(RCOfferings * _Nullable, NSError * _Nullable))completionHandler __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6,2), TV (13,0), Mac (10,15), iOS (13,0)]
	[Export ("offeringsWithCompletionHandler:")]
	void OfferingsWithCompletionHandler (Action<RCOfferings, NSError> completionHandler);
}

// @interface RevenueCat_Swift_6025 (RCPurchases)
[Category]
[BaseType (typeof(RCPurchases))]
interface RCPurchases_RevenueCat_Swift_6025
{
	// +(RCPurchases * _Nonnull)configureWithAPIKey:(NSString * _Nonnull)apiKey appUserID:(NSString * _Nullable)appUserID observerMode:(BOOL)observerMode userDefaults:(NSUserDefaults * _Nullable)userDefaults __attribute__((availability(maccatalyst, deprecated=1))) __attribute__((availability(macos, deprecated=1))) __attribute__((availability(watchos, deprecated=1))) __attribute__((availability(tvos, deprecated=1))) __attribute__((availability(ios, deprecated=1)));
	[Deprecated (PlatformName.MacCatalyst, 1, 0, message: "'configure' has been renamed to 'configure(with:)'")]
	[Deprecated (PlatformName.MacOSX, 1, 0, message: "'configure' has been renamed to 'configure(with:)'")]
	[Deprecated (PlatformName.WatchOS, 1, 0, message: "'configure' has been renamed to 'configure(with:)'")]
	[Deprecated (PlatformName.TvOS, 1, 0, message: "'configure' has been renamed to 'configure(with:)'")]
	[Deprecated (PlatformName.iOS, 1, 0, message: "'configure' has been renamed to 'configure(with:)'")]
	[Static]
	[Export ("configureWithAPIKey:appUserID:observerMode:userDefaults:")]
	RCPurchases ConfigureWithAPIKey (string apiKey, [NullAllowed] string appUserID, bool observerMode, [NullAllowed] NSUserDefaults userDefaults);

	// +(RCPurchases * _Nonnull)configureWithAPIKey:(NSString * _Nonnull)apiKey appUserID:(NSString * _Nullable)appUserID observerMode:(BOOL)observerMode userDefaults:(NSUserDefaults * _Nullable)userDefaults useStoreKit2IfAvailable:(BOOL)useStoreKit2IfAvailable __attribute__((availability(maccatalyst, deprecated=1))) __attribute__((availability(macos, deprecated=1))) __attribute__((availability(watchos, deprecated=1))) __attribute__((availability(tvos, deprecated=1))) __attribute__((availability(ios, deprecated=1)));
	[Deprecated (PlatformName.MacCatalyst, 1, 0, message: "'configure' has been renamed to 'configure(with:)'")]
	[Deprecated (PlatformName.MacOSX, 1, 0, message: "'configure' has been renamed to 'configure(with:)'")]
	[Deprecated (PlatformName.WatchOS, 1, 0, message: "'configure' has been renamed to 'configure(with:)'")]
	[Deprecated (PlatformName.TvOS, 1, 0, message: "'configure' has been renamed to 'configure(with:)'")]
	[Deprecated (PlatformName.iOS, 1, 0, message: "'configure' has been renamed to 'configure(with:)'")]
	[Static]
	[Export ("configureWithAPIKey:appUserID:observerMode:userDefaults:useStoreKit2IfAvailable:")]
	RCPurchases ConfigureWithAPIKey (string apiKey, [NullAllowed] string appUserID, bool observerMode, [NullAllowed] NSUserDefaults userDefaults, bool useStoreKit2IfAvailable);

	// +(RCPurchases * _Nonnull)configureWithAPIKey:(NSString * _Nonnull)apiKey appUserID:(NSString * _Nullable)appUserID observerMode:(BOOL)observerMode userDefaults:(NSUserDefaults * _Nullable)userDefaults useStoreKit2IfAvailable:(BOOL)useStoreKit2IfAvailable dangerousSettings:(RCDangerousSettings * _Nullable)dangerousSettings __attribute__((availability(maccatalyst, deprecated=1))) __attribute__((availability(macos, deprecated=1))) __attribute__((availability(watchos, deprecated=1))) __attribute__((availability(tvos, deprecated=1))) __attribute__((availability(ios, deprecated=1)));
	[Deprecated (PlatformName.MacCatalyst, 1, 0, message: "'configure' has been renamed to 'configure(with:)'")]
	[Deprecated (PlatformName.MacOSX, 1, 0, message: "'configure' has been renamed to 'configure(with:)'")]
	[Deprecated (PlatformName.WatchOS, 1, 0, message: "'configure' has been renamed to 'configure(with:)'")]
	[Deprecated (PlatformName.TvOS, 1, 0, message: "'configure' has been renamed to 'configure(with:)'")]
	[Deprecated (PlatformName.iOS, 1, 0, message: "'configure' has been renamed to 'configure(with:)'")]
	[Static]
	[Export ("configureWithAPIKey:appUserID:observerMode:userDefaults:useStoreKit2IfAvailable:dangerousSettings:")]
	RCPurchases ConfigureWithAPIKey (string apiKey, [NullAllowed] string appUserID, bool observerMode, [NullAllowed] NSUserDefaults userDefaults, bool useStoreKit2IfAvailable, [NullAllowed] RCDangerousSettings dangerousSettings);

	// @property (nonatomic, class) BOOL automaticAppleSearchAdsAttributionCollection __attribute__((deprecated("Use Purchases.shared.attribution.enableAdServicesAttributionTokenCollection() instead")));
	[Static]
	[Export ("automaticAppleSearchAdsAttributionCollection")]
	bool AutomaticAppleSearchAdsAttributionCollection { get; set; }
}

// @interface RevenueCat_Swift_6039 (RCPurchases)
[Category]
[BaseType (typeof(RCPurchases))]
interface RCPurchases_RevenueCat_Swift_6039
{
	// -(void)collectDeviceIdentifiers __attribute__((availability(maccatalyst, deprecated=0.0.1))) __attribute__((availability(macos, deprecated=0.0.1))) __attribute__((availability(watchos, deprecated=0.0.1))) __attribute__((availability(tvos, deprecated=0.0.1))) __attribute__((availability(ios, deprecated=0.0.1)));
	[Deprecated (PlatformName.MacCatalyst, 0, 0, 1, message: "'collectDeviceIdentifiers' has been renamed to 'attribution.collectDeviceIdentifiers()'")]
	[Deprecated (PlatformName.MacOSX, 0, 0, 1, message: "'collectDeviceIdentifiers' has been renamed to 'attribution.collectDeviceIdentifiers()'")]
	[Deprecated (PlatformName.WatchOS, 0, 0, 1, message: "'collectDeviceIdentifiers' has been renamed to 'attribution.collectDeviceIdentifiers()'")]
	[Deprecated (PlatformName.TvOS, 0, 0, 1, message: "'collectDeviceIdentifiers' has been renamed to 'attribution.collectDeviceIdentifiers()'")]
	[Deprecated (PlatformName.iOS, 0, 0, 1, message: "'collectDeviceIdentifiers' has been renamed to 'attribution.collectDeviceIdentifiers()'")]
	[Export ("collectDeviceIdentifiers")]
	void CollectDeviceIdentifiers ();

	// -(void)setAttributes:(NSDictionary<NSString *,NSString *> * _Nonnull)attributes __attribute__((availability(maccatalyst, deprecated=0.0.1))) __attribute__((availability(macos, deprecated=0.0.1))) __attribute__((availability(watchos, deprecated=0.0.1))) __attribute__((availability(tvos, deprecated=0.0.1))) __attribute__((availability(ios, deprecated=0.0.1)));
	[Deprecated (PlatformName.MacCatalyst, 0, 0, 1, message: "'setAttributes' has been renamed to 'attribution.setAttributes(_:)'")]
	[Deprecated (PlatformName.MacOSX, 0, 0, 1, message: "'setAttributes' has been renamed to 'attribution.setAttributes(_:)'")]
	[Deprecated (PlatformName.WatchOS, 0, 0, 1, message: "'setAttributes' has been renamed to 'attribution.setAttributes(_:)'")]
	[Deprecated (PlatformName.TvOS, 0, 0, 1, message: "'setAttributes' has been renamed to 'attribution.setAttributes(_:)'")]
	[Deprecated (PlatformName.iOS, 0, 0, 1, message: "'setAttributes' has been renamed to 'attribution.setAttributes(_:)'")]
	[Export ("setAttributes:")]
	void SetAttributes (NSDictionary<NSString, NSString> attributes);

	// -(void)setEmail:(NSString * _Nullable)email __attribute__((availability(maccatalyst, deprecated=0.0.1))) __attribute__((availability(macos, deprecated=0.0.1))) __attribute__((availability(watchos, deprecated=0.0.1))) __attribute__((availability(tvos, deprecated=0.0.1))) __attribute__((availability(ios, deprecated=0.0.1)));
	[Deprecated (PlatformName.MacCatalyst, 0, 0, 1, message: "'setEmail' has been renamed to 'attribution.setEmail(_:)'")]
	[Deprecated (PlatformName.MacOSX, 0, 0, 1, message: "'setEmail' has been renamed to 'attribution.setEmail(_:)'")]
	[Deprecated (PlatformName.WatchOS, 0, 0, 1, message: "'setEmail' has been renamed to 'attribution.setEmail(_:)'")]
	[Deprecated (PlatformName.TvOS, 0, 0, 1, message: "'setEmail' has been renamed to 'attribution.setEmail(_:)'")]
	[Deprecated (PlatformName.iOS, 0, 0, 1, message: "'setEmail' has been renamed to 'attribution.setEmail(_:)'")]
	[Export ("setEmail:")]
	void SetEmail ([NullAllowed] string email);

	// -(void)setPhoneNumber:(NSString * _Nullable)phoneNumber __attribute__((availability(maccatalyst, deprecated=0.0.1))) __attribute__((availability(macos, deprecated=0.0.1))) __attribute__((availability(watchos, deprecated=0.0.1))) __attribute__((availability(tvos, deprecated=0.0.1))) __attribute__((availability(ios, deprecated=0.0.1)));
	[Deprecated (PlatformName.MacCatalyst, 0, 0, 1, message: "'setPhoneNumber' has been renamed to 'attribution.setPhoneNumber(_:)'")]
	[Deprecated (PlatformName.MacOSX, 0, 0, 1, message: "'setPhoneNumber' has been renamed to 'attribution.setPhoneNumber(_:)'")]
	[Deprecated (PlatformName.WatchOS, 0, 0, 1, message: "'setPhoneNumber' has been renamed to 'attribution.setPhoneNumber(_:)'")]
	[Deprecated (PlatformName.TvOS, 0, 0, 1, message: "'setPhoneNumber' has been renamed to 'attribution.setPhoneNumber(_:)'")]
	[Deprecated (PlatformName.iOS, 0, 0, 1, message: "'setPhoneNumber' has been renamed to 'attribution.setPhoneNumber(_:)'")]
	[Export ("setPhoneNumber:")]
	void SetPhoneNumber ([NullAllowed] string phoneNumber);

	// -(void)setDisplayName:(NSString * _Nullable)displayName __attribute__((availability(maccatalyst, deprecated=0.0.1))) __attribute__((availability(macos, deprecated=0.0.1))) __attribute__((availability(watchos, deprecated=0.0.1))) __attribute__((availability(tvos, deprecated=0.0.1))) __attribute__((availability(ios, deprecated=0.0.1)));
	[Deprecated (PlatformName.MacCatalyst, 0, 0, 1, message: "'setDisplayName' has been renamed to 'attribution.setDisplayName(_:)'")]
	[Deprecated (PlatformName.MacOSX, 0, 0, 1, message: "'setDisplayName' has been renamed to 'attribution.setDisplayName(_:)'")]
	[Deprecated (PlatformName.WatchOS, 0, 0, 1, message: "'setDisplayName' has been renamed to 'attribution.setDisplayName(_:)'")]
	[Deprecated (PlatformName.TvOS, 0, 0, 1, message: "'setDisplayName' has been renamed to 'attribution.setDisplayName(_:)'")]
	[Deprecated (PlatformName.iOS, 0, 0, 1, message: "'setDisplayName' has been renamed to 'attribution.setDisplayName(_:)'")]
	[Export ("setDisplayName:")]
	void SetDisplayName ([NullAllowed] string displayName);

	// -(void)setPushToken:(NSData * _Nullable)pushToken __attribute__((availability(maccatalyst, deprecated=0.0.1))) __attribute__((availability(macos, deprecated=0.0.1))) __attribute__((availability(watchos, deprecated=0.0.1))) __attribute__((availability(tvos, deprecated=0.0.1))) __attribute__((availability(ios, deprecated=0.0.1)));
	[Deprecated (PlatformName.MacCatalyst, 0, 0, 1, message: "'setPushToken' has been renamed to 'attribution.setPushToken(_:)'")]
	[Deprecated (PlatformName.MacOSX, 0, 0, 1, message: "'setPushToken' has been renamed to 'attribution.setPushToken(_:)'")]
	[Deprecated (PlatformName.WatchOS, 0, 0, 1, message: "'setPushToken' has been renamed to 'attribution.setPushToken(_:)'")]
	[Deprecated (PlatformName.TvOS, 0, 0, 1, message: "'setPushToken' has been renamed to 'attribution.setPushToken(_:)'")]
	[Deprecated (PlatformName.iOS, 0, 0, 1, message: "'setPushToken' has been renamed to 'attribution.setPushToken(_:)'")]
	[Export ("setPushToken:")]
	void SetPushToken ([NullAllowed] NSData pushToken);

	// -(void)setPushTokenString:(NSString * _Nullable)pushToken __attribute__((availability(maccatalyst, deprecated=0.0.1))) __attribute__((availability(macos, deprecated=0.0.1))) __attribute__((availability(watchos, deprecated=0.0.1))) __attribute__((availability(tvos, deprecated=0.0.1))) __attribute__((availability(ios, deprecated=0.0.1)));
	[Deprecated (PlatformName.MacCatalyst, 0, 0, 1, message: "'setPushTokenString' has been renamed to 'attribution.setPushTokenString(_:)'")]
	[Deprecated (PlatformName.MacOSX, 0, 0, 1, message: "'setPushTokenString' has been renamed to 'attribution.setPushTokenString(_:)'")]
	[Deprecated (PlatformName.WatchOS, 0, 0, 1, message: "'setPushTokenString' has been renamed to 'attribution.setPushTokenString(_:)'")]
	[Deprecated (PlatformName.TvOS, 0, 0, 1, message: "'setPushTokenString' has been renamed to 'attribution.setPushTokenString(_:)'")]
	[Deprecated (PlatformName.iOS, 0, 0, 1, message: "'setPushTokenString' has been renamed to 'attribution.setPushTokenString(_:)'")]
	[Export ("setPushTokenString:")]
	void SetPushTokenString ([NullAllowed] string pushToken);

	// -(void)setAdjustID:(NSString * _Nullable)adjustID __attribute__((availability(maccatalyst, deprecated=0.0.1))) __attribute__((availability(macos, deprecated=0.0.1))) __attribute__((availability(watchos, deprecated=0.0.1))) __attribute__((availability(tvos, deprecated=0.0.1))) __attribute__((availability(ios, deprecated=0.0.1)));
	[Deprecated (PlatformName.MacCatalyst, 0, 0, 1, message: "'setAdjustID' has been renamed to 'attribution.setAdjustID(_:)'")]
	[Deprecated (PlatformName.MacOSX, 0, 0, 1, message: "'setAdjustID' has been renamed to 'attribution.setAdjustID(_:)'")]
	[Deprecated (PlatformName.WatchOS, 0, 0, 1, message: "'setAdjustID' has been renamed to 'attribution.setAdjustID(_:)'")]
	[Deprecated (PlatformName.TvOS, 0, 0, 1, message: "'setAdjustID' has been renamed to 'attribution.setAdjustID(_:)'")]
	[Deprecated (PlatformName.iOS, 0, 0, 1, message: "'setAdjustID' has been renamed to 'attribution.setAdjustID(_:)'")]
	[Export ("setAdjustID:")]
	void SetAdjustID ([NullAllowed] string adjustID);

	// -(void)setAppsflyerID:(NSString * _Nullable)appsflyerID __attribute__((availability(maccatalyst, deprecated=0.0.1))) __attribute__((availability(macos, deprecated=0.0.1))) __attribute__((availability(watchos, deprecated=0.0.1))) __attribute__((availability(tvos, deprecated=0.0.1))) __attribute__((availability(ios, deprecated=0.0.1)));
	[Deprecated (PlatformName.MacCatalyst, 0, 0, 1, message: "'setAppsflyerID' has been renamed to 'attribution.setAppsflyerID(_:)'")]
	[Deprecated (PlatformName.MacOSX, 0, 0, 1, message: "'setAppsflyerID' has been renamed to 'attribution.setAppsflyerID(_:)'")]
	[Deprecated (PlatformName.WatchOS, 0, 0, 1, message: "'setAppsflyerID' has been renamed to 'attribution.setAppsflyerID(_:)'")]
	[Deprecated (PlatformName.TvOS, 0, 0, 1, message: "'setAppsflyerID' has been renamed to 'attribution.setAppsflyerID(_:)'")]
	[Deprecated (PlatformName.iOS, 0, 0, 1, message: "'setAppsflyerID' has been renamed to 'attribution.setAppsflyerID(_:)'")]
	[Export ("setAppsflyerID:")]
	void SetAppsflyerID ([NullAllowed] string appsflyerID);

	// -(void)setFBAnonymousID:(NSString * _Nullable)fbAnonymousID __attribute__((availability(maccatalyst, deprecated=0.0.1))) __attribute__((availability(macos, deprecated=0.0.1))) __attribute__((availability(watchos, deprecated=0.0.1))) __attribute__((availability(tvos, deprecated=0.0.1))) __attribute__((availability(ios, deprecated=0.0.1)));
	[Deprecated (PlatformName.MacCatalyst, 0, 0, 1, message: "'setFBAnonymousID' has been renamed to 'attribution.setFBAnonymousID(_:)'")]
	[Deprecated (PlatformName.MacOSX, 0, 0, 1, message: "'setFBAnonymousID' has been renamed to 'attribution.setFBAnonymousID(_:)'")]
	[Deprecated (PlatformName.WatchOS, 0, 0, 1, message: "'setFBAnonymousID' has been renamed to 'attribution.setFBAnonymousID(_:)'")]
	[Deprecated (PlatformName.TvOS, 0, 0, 1, message: "'setFBAnonymousID' has been renamed to 'attribution.setFBAnonymousID(_:)'")]
	[Deprecated (PlatformName.iOS, 0, 0, 1, message: "'setFBAnonymousID' has been renamed to 'attribution.setFBAnonymousID(_:)'")]
	[Export ("setFBAnonymousID:")]
	void SetFBAnonymousID ([NullAllowed] string fbAnonymousID);

	// -(void)setMparticleID:(NSString * _Nullable)mparticleID __attribute__((availability(maccatalyst, deprecated=0.0.1))) __attribute__((availability(macos, deprecated=0.0.1))) __attribute__((availability(watchos, deprecated=0.0.1))) __attribute__((availability(tvos, deprecated=0.0.1))) __attribute__((availability(ios, deprecated=0.0.1)));
	[Deprecated (PlatformName.MacCatalyst, 0, 0, 1, message: "'setMparticleID' has been renamed to 'attribution.setMparticleID(_:)'")]
	[Deprecated (PlatformName.MacOSX, 0, 0, 1, message: "'setMparticleID' has been renamed to 'attribution.setMparticleID(_:)'")]
	[Deprecated (PlatformName.WatchOS, 0, 0, 1, message: "'setMparticleID' has been renamed to 'attribution.setMparticleID(_:)'")]
	[Deprecated (PlatformName.TvOS, 0, 0, 1, message: "'setMparticleID' has been renamed to 'attribution.setMparticleID(_:)'")]
	[Deprecated (PlatformName.iOS, 0, 0, 1, message: "'setMparticleID' has been renamed to 'attribution.setMparticleID(_:)'")]
	[Export ("setMparticleID:")]
	void SetMparticleID ([NullAllowed] string mparticleID);

	// -(void)setOnesignalID:(NSString * _Nullable)onesignalID __attribute__((availability(maccatalyst, deprecated=0.0.1))) __attribute__((availability(macos, deprecated=0.0.1))) __attribute__((availability(watchos, deprecated=0.0.1))) __attribute__((availability(tvos, deprecated=0.0.1))) __attribute__((availability(ios, deprecated=0.0.1)));
	[Deprecated (PlatformName.MacCatalyst, 0, 0, 1, message: "'setOnesignalID' has been renamed to 'attribution.setOnesignalID(_:)'")]
	[Deprecated (PlatformName.MacOSX, 0, 0, 1, message: "'setOnesignalID' has been renamed to 'attribution.setOnesignalID(_:)'")]
	[Deprecated (PlatformName.WatchOS, 0, 0, 1, message: "'setOnesignalID' has been renamed to 'attribution.setOnesignalID(_:)'")]
	[Deprecated (PlatformName.TvOS, 0, 0, 1, message: "'setOnesignalID' has been renamed to 'attribution.setOnesignalID(_:)'")]
	[Deprecated (PlatformName.iOS, 0, 0, 1, message: "'setOnesignalID' has been renamed to 'attribution.setOnesignalID(_:)'")]
	[Export ("setOnesignalID:")]
	void SetOnesignalID ([NullAllowed] string onesignalID);

	// -(void)setAirshipChannelID:(NSString * _Nullable)airshipChannelID __attribute__((availability(maccatalyst, deprecated=0.0.1))) __attribute__((availability(macos, deprecated=0.0.1))) __attribute__((availability(watchos, deprecated=0.0.1))) __attribute__((availability(tvos, deprecated=0.0.1))) __attribute__((availability(ios, deprecated=0.0.1)));
	[Deprecated (PlatformName.MacCatalyst, 0, 0, 1, message: "'setAirshipChannelID' has been renamed to 'attribution.setAirshipChannelID(_:)'")]
	[Deprecated (PlatformName.MacOSX, 0, 0, 1, message: "'setAirshipChannelID' has been renamed to 'attribution.setAirshipChannelID(_:)'")]
	[Deprecated (PlatformName.WatchOS, 0, 0, 1, message: "'setAirshipChannelID' has been renamed to 'attribution.setAirshipChannelID(_:)'")]
	[Deprecated (PlatformName.TvOS, 0, 0, 1, message: "'setAirshipChannelID' has been renamed to 'attribution.setAirshipChannelID(_:)'")]
	[Deprecated (PlatformName.iOS, 0, 0, 1, message: "'setAirshipChannelID' has been renamed to 'attribution.setAirshipChannelID(_:)'")]
	[Export ("setAirshipChannelID:")]
	void SetAirshipChannelID ([NullAllowed] string airshipChannelID);

	// -(void)setCleverTapID:(NSString * _Nullable)cleverTapID __attribute__((availability(maccatalyst, deprecated=0.0.1))) __attribute__((availability(macos, deprecated=0.0.1))) __attribute__((availability(watchos, deprecated=0.0.1))) __attribute__((availability(tvos, deprecated=0.0.1))) __attribute__((availability(ios, deprecated=0.0.1)));
	[Deprecated (PlatformName.MacCatalyst, 0, 0, 1, message: "'setCleverTapID' has been renamed to 'attribution.setCleverTapID(_:)'")]
	[Deprecated (PlatformName.MacOSX, 0, 0, 1, message: "'setCleverTapID' has been renamed to 'attribution.setCleverTapID(_:)'")]
	[Deprecated (PlatformName.WatchOS, 0, 0, 1, message: "'setCleverTapID' has been renamed to 'attribution.setCleverTapID(_:)'")]
	[Deprecated (PlatformName.TvOS, 0, 0, 1, message: "'setCleverTapID' has been renamed to 'attribution.setCleverTapID(_:)'")]
	[Deprecated (PlatformName.iOS, 0, 0, 1, message: "'setCleverTapID' has been renamed to 'attribution.setCleverTapID(_:)'")]
	[Export ("setCleverTapID:")]
	void SetCleverTapID ([NullAllowed] string cleverTapID);

	// -(void)setMixpanelDistinctID:(NSString * _Nullable)mixpanelDistinctID __attribute__((availability(maccatalyst, deprecated=0.0.1))) __attribute__((availability(macos, deprecated=0.0.1))) __attribute__((availability(watchos, deprecated=0.0.1))) __attribute__((availability(tvos, deprecated=0.0.1))) __attribute__((availability(ios, deprecated=0.0.1)));
	[Deprecated (PlatformName.MacCatalyst, 0, 0, 1, message: "'setMixpanelDistinctID' has been renamed to 'attribution.setMixpanelDistinctID(_:)'")]
	[Deprecated (PlatformName.MacOSX, 0, 0, 1, message: "'setMixpanelDistinctID' has been renamed to 'attribution.setMixpanelDistinctID(_:)'")]
	[Deprecated (PlatformName.WatchOS, 0, 0, 1, message: "'setMixpanelDistinctID' has been renamed to 'attribution.setMixpanelDistinctID(_:)'")]
	[Deprecated (PlatformName.TvOS, 0, 0, 1, message: "'setMixpanelDistinctID' has been renamed to 'attribution.setMixpanelDistinctID(_:)'")]
	[Deprecated (PlatformName.iOS, 0, 0, 1, message: "'setMixpanelDistinctID' has been renamed to 'attribution.setMixpanelDistinctID(_:)'")]
	[Export ("setMixpanelDistinctID:")]
	void SetMixpanelDistinctID ([NullAllowed] string mixpanelDistinctID);

	// -(void)setFirebaseAppInstanceID:(NSString * _Nullable)firebaseAppInstanceID __attribute__((availability(maccatalyst, deprecated=0.0.1))) __attribute__((availability(macos, deprecated=0.0.1))) __attribute__((availability(watchos, deprecated=0.0.1))) __attribute__((availability(tvos, deprecated=0.0.1))) __attribute__((availability(ios, deprecated=0.0.1)));
	[Deprecated (PlatformName.MacCatalyst, 0, 0, 1, message: "'setFirebaseAppInstanceID' has been renamed to 'attribution.setFirebaseAppInstanceID(_:)'")]
	[Deprecated (PlatformName.MacOSX, 0, 0, 1, message: "'setFirebaseAppInstanceID' has been renamed to 'attribution.setFirebaseAppInstanceID(_:)'")]
	[Deprecated (PlatformName.WatchOS, 0, 0, 1, message: "'setFirebaseAppInstanceID' has been renamed to 'attribution.setFirebaseAppInstanceID(_:)'")]
	[Deprecated (PlatformName.TvOS, 0, 0, 1, message: "'setFirebaseAppInstanceID' has been renamed to 'attribution.setFirebaseAppInstanceID(_:)'")]
	[Deprecated (PlatformName.iOS, 0, 0, 1, message: "'setFirebaseAppInstanceID' has been renamed to 'attribution.setFirebaseAppInstanceID(_:)'")]
	[Export ("setFirebaseAppInstanceID:")]
	void SetFirebaseAppInstanceID ([NullAllowed] string firebaseAppInstanceID);

	// -(void)setMediaSource:(NSString * _Nullable)mediaSource __attribute__((availability(maccatalyst, deprecated=0.0.1))) __attribute__((availability(macos, deprecated=0.0.1))) __attribute__((availability(watchos, deprecated=0.0.1))) __attribute__((availability(tvos, deprecated=0.0.1))) __attribute__((availability(ios, deprecated=0.0.1)));
	[Deprecated (PlatformName.MacCatalyst, 0, 0, 1, message: "'setMediaSource' has been renamed to 'attribution.setMediaSource(_:)'")]
	[Deprecated (PlatformName.MacOSX, 0, 0, 1, message: "'setMediaSource' has been renamed to 'attribution.setMediaSource(_:)'")]
	[Deprecated (PlatformName.WatchOS, 0, 0, 1, message: "'setMediaSource' has been renamed to 'attribution.setMediaSource(_:)'")]
	[Deprecated (PlatformName.TvOS, 0, 0, 1, message: "'setMediaSource' has been renamed to 'attribution.setMediaSource(_:)'")]
	[Deprecated (PlatformName.iOS, 0, 0, 1, message: "'setMediaSource' has been renamed to 'attribution.setMediaSource(_:)'")]
	[Export ("setMediaSource:")]
	void SetMediaSource ([NullAllowed] string mediaSource);

	// -(void)setCampaign:(NSString * _Nullable)campaign __attribute__((availability(maccatalyst, deprecated=0.0.1))) __attribute__((availability(macos, deprecated=0.0.1))) __attribute__((availability(watchos, deprecated=0.0.1))) __attribute__((availability(tvos, deprecated=0.0.1))) __attribute__((availability(ios, deprecated=0.0.1)));
	[Deprecated (PlatformName.MacCatalyst, 0, 0, 1, message: "'setCampaign' has been renamed to 'attribution.setCampaign(_:)'")]
	[Deprecated (PlatformName.MacOSX, 0, 0, 1, message: "'setCampaign' has been renamed to 'attribution.setCampaign(_:)'")]
	[Deprecated (PlatformName.WatchOS, 0, 0, 1, message: "'setCampaign' has been renamed to 'attribution.setCampaign(_:)'")]
	[Deprecated (PlatformName.TvOS, 0, 0, 1, message: "'setCampaign' has been renamed to 'attribution.setCampaign(_:)'")]
	[Deprecated (PlatformName.iOS, 0, 0, 1, message: "'setCampaign' has been renamed to 'attribution.setCampaign(_:)'")]
	[Export ("setCampaign:")]
	void SetCampaign ([NullAllowed] string campaign);

	// -(void)setAdGroup:(NSString * _Nullable)adGroup __attribute__((availability(maccatalyst, deprecated=0.0.1))) __attribute__((availability(macos, deprecated=0.0.1))) __attribute__((availability(watchos, deprecated=0.0.1))) __attribute__((availability(tvos, deprecated=0.0.1))) __attribute__((availability(ios, deprecated=0.0.1)));
	[Deprecated (PlatformName.MacCatalyst, 0, 0, 1, message: "'setAdGroup' has been renamed to 'attribution.setAdGroup(_:)'")]
	[Deprecated (PlatformName.MacOSX, 0, 0, 1, message: "'setAdGroup' has been renamed to 'attribution.setAdGroup(_:)'")]
	[Deprecated (PlatformName.WatchOS, 0, 0, 1, message: "'setAdGroup' has been renamed to 'attribution.setAdGroup(_:)'")]
	[Deprecated (PlatformName.TvOS, 0, 0, 1, message: "'setAdGroup' has been renamed to 'attribution.setAdGroup(_:)'")]
	[Deprecated (PlatformName.iOS, 0, 0, 1, message: "'setAdGroup' has been renamed to 'attribution.setAdGroup(_:)'")]
	[Export ("setAdGroup:")]
	void SetAdGroup ([NullAllowed] string adGroup);

	// -(void)setAd:(NSString * _Nullable)installAd __attribute__((availability(maccatalyst, deprecated=0.0.1))) __attribute__((availability(macos, deprecated=0.0.1))) __attribute__((availability(watchos, deprecated=0.0.1))) __attribute__((availability(tvos, deprecated=0.0.1))) __attribute__((availability(ios, deprecated=0.0.1)));
	[Deprecated (PlatformName.MacCatalyst, 0, 0, 1, message: "'setAd' has been renamed to 'attribution.setAd(_:)'")]
	[Deprecated (PlatformName.MacOSX, 0, 0, 1, message: "'setAd' has been renamed to 'attribution.setAd(_:)'")]
	[Deprecated (PlatformName.WatchOS, 0, 0, 1, message: "'setAd' has been renamed to 'attribution.setAd(_:)'")]
	[Deprecated (PlatformName.TvOS, 0, 0, 1, message: "'setAd' has been renamed to 'attribution.setAd(_:)'")]
	[Deprecated (PlatformName.iOS, 0, 0, 1, message: "'setAd' has been renamed to 'attribution.setAd(_:)'")]
	[Export ("setAd:")]
	void SetAd ([NullAllowed] string installAd);

	// -(void)setKeyword:(NSString * _Nullable)keyword __attribute__((availability(maccatalyst, deprecated=0.0.1))) __attribute__((availability(macos, deprecated=0.0.1))) __attribute__((availability(watchos, deprecated=0.0.1))) __attribute__((availability(tvos, deprecated=0.0.1))) __attribute__((availability(ios, deprecated=0.0.1)));
	[Deprecated (PlatformName.MacCatalyst, 0, 0, 1, message: "'setKeyword' has been renamed to 'attribution.setKeyword(_:)'")]
	[Deprecated (PlatformName.MacOSX, 0, 0, 1, message: "'setKeyword' has been renamed to 'attribution.setKeyword(_:)'")]
	[Deprecated (PlatformName.WatchOS, 0, 0, 1, message: "'setKeyword' has been renamed to 'attribution.setKeyword(_:)'")]
	[Deprecated (PlatformName.TvOS, 0, 0, 1, message: "'setKeyword' has been renamed to 'attribution.setKeyword(_:)'")]
	[Deprecated (PlatformName.iOS, 0, 0, 1, message: "'setKeyword' has been renamed to 'attribution.setKeyword(_:)'")]
	[Export ("setKeyword:")]
	void SetKeyword ([NullAllowed] string keyword);

	// -(void)setCreative:(NSString * _Nullable)creative __attribute__((availability(maccatalyst, deprecated=0.0.1))) __attribute__((availability(macos, deprecated=0.0.1))) __attribute__((availability(watchos, deprecated=0.0.1))) __attribute__((availability(tvos, deprecated=0.0.1))) __attribute__((availability(ios, deprecated=0.0.1)));
	[Deprecated (PlatformName.MacCatalyst, 0, 0, 1, message: "'setCreative' has been renamed to 'attribution.setCreative(_:)'")]
	[Deprecated (PlatformName.MacOSX, 0, 0, 1, message: "'setCreative' has been renamed to 'attribution.setCreative(_:)'")]
	[Deprecated (PlatformName.WatchOS, 0, 0, 1, message: "'setCreative' has been renamed to 'attribution.setCreative(_:)'")]
	[Deprecated (PlatformName.TvOS, 0, 0, 1, message: "'setCreative' has been renamed to 'attribution.setCreative(_:)'")]
	[Deprecated (PlatformName.iOS, 0, 0, 1, message: "'setCreative' has been renamed to 'attribution.setCreative(_:)'")]
	[Export ("setCreative:")]
	void SetCreative ([NullAllowed] string creative);
}

// @interface RevenueCat_Swift_6067 (RCPurchases)
[Category]
[BaseType (typeof(RCPurchases))]
interface RCPurchases_RevenueCat_Swift_6067
{
	// -(void)restoreTransactionsWithCompletionBlock:(void (^ _Nullable)(RCCustomerInfo * _Nullable, NSError * _Nullable))completion __attribute__((availability(macos, obsoleted=1))) __attribute__((availability(watchos, obsoleted=1))) __attribute__((availability(tvos, obsoleted=1))) __attribute__((availability(ios, obsoleted=1)));
	[Obsoleted (PlatformName.MacOSX, 1, 0, message: "'restoreTransactions' has been renamed to 'restorePurchasesWithCompletion:'")]
	[Obsoleted (PlatformName.WatchOS, 1, 0, message: "'restoreTransactions' has been renamed to 'restorePurchasesWithCompletion:'")]
	[Obsoleted (PlatformName.TvOS, 1, 0, message: "'restoreTransactions' has been renamed to 'restorePurchasesWithCompletion:'")]
	[Obsoleted (PlatformName.iOS, 1, 0, message: "'restoreTransactions' has been renamed to 'restorePurchasesWithCompletion:'")]
	[Export ("restoreTransactionsWithCompletionBlock:")]
	void RestoreTransactionsWithCompletionBlock ([NullAllowed] Action<RCCustomerInfo, NSError> completion);

	// -(void)customerInfoWithCompletion:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, NSError * _Nullable))completion __attribute__((availability(macos, obsoleted=1))) __attribute__((availability(watchos, obsoleted=1))) __attribute__((availability(tvos, obsoleted=1))) __attribute__((availability(ios, obsoleted=1)));
	[Obsoleted (PlatformName.MacOSX, 1, 0, message: "'customerInfo' has been renamed to 'getCustomerInfoWithCompletion:'")]
	[Obsoleted (PlatformName.WatchOS, 1, 0, message: "'customerInfo' has been renamed to 'getCustomerInfoWithCompletion:'")]
	[Obsoleted (PlatformName.TvOS, 1, 0, message: "'customerInfo' has been renamed to 'getCustomerInfoWithCompletion:'")]
	[Obsoleted (PlatformName.iOS, 1, 0, message: "'customerInfo' has been renamed to 'getCustomerInfoWithCompletion:'")]
	[Export ("customerInfoWithCompletion:")]
	void CustomerInfoWithCompletion (Action<RCCustomerInfo, NSError> completion);

	// -(void)purchaserInfoWithCompletionBlock:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, NSError * _Nullable))completion __attribute__((availability(macos, obsoleted=1))) __attribute__((availability(watchos, obsoleted=1))) __attribute__((availability(tvos, obsoleted=1))) __attribute__((availability(ios, obsoleted=1)));
	[Obsoleted (PlatformName.MacOSX, 1, 0, message: "'purchaserInfo' has been renamed to 'getCustomerInfoWithCompletion:'")]
	[Obsoleted (PlatformName.WatchOS, 1, 0, message: "'purchaserInfo' has been renamed to 'getCustomerInfoWithCompletion:'")]
	[Obsoleted (PlatformName.TvOS, 1, 0, message: "'purchaserInfo' has been renamed to 'getCustomerInfoWithCompletion:'")]
	[Obsoleted (PlatformName.iOS, 1, 0, message: "'purchaserInfo' has been renamed to 'getCustomerInfoWithCompletion:'")]
	[Export ("purchaserInfoWithCompletionBlock:")]
	void PurchaserInfoWithCompletionBlock (Action<RCCustomerInfo, NSError> completion);

	// -(void)productsWithIdentifiers:(NSArray<NSString *> * _Nonnull)productIdentifiers completionBlock:(void (^ _Nonnull)(NSArray<SKProduct *> * _Nonnull))completion __attribute__((availability(macos, obsoleted=1))) __attribute__((availability(watchos, obsoleted=1))) __attribute__((availability(tvos, obsoleted=1))) __attribute__((availability(ios, obsoleted=1)));
	[Obsoleted (PlatformName.MacOSX, 1, 0, message: "'products' has been renamed to 'getProductsWithIdentifiers:completion:'")]
	[Obsoleted (PlatformName.WatchOS, 1, 0, message: "'products' has been renamed to 'getProductsWithIdentifiers:completion:'")]
	[Obsoleted (PlatformName.TvOS, 1, 0, message: "'products' has been renamed to 'getProductsWithIdentifiers:completion:'")]
	[Obsoleted (PlatformName.iOS, 1, 0, message: "'products' has been renamed to 'getProductsWithIdentifiers:completion:'")]
	[Export ("productsWithIdentifiers:completionBlock:")]
	void ProductsWithIdentifiers (string[] productIdentifiers, Action<NSArray<SKProduct>> completion);

	// -(void)offeringsWithCompletionBlock:(void (^ _Nonnull)(RCOfferings * _Nullable, NSError * _Nullable))completion __attribute__((availability(macos, obsoleted=1))) __attribute__((availability(watchos, obsoleted=1))) __attribute__((availability(tvos, obsoleted=1))) __attribute__((availability(ios, obsoleted=1)));
	[Obsoleted (PlatformName.MacOSX, 1, 0, message: "'offerings' has been renamed to 'getOfferingsWithCompletion:'")]
	[Obsoleted (PlatformName.WatchOS, 1, 0, message: "'offerings' has been renamed to 'getOfferingsWithCompletion:'")]
	[Obsoleted (PlatformName.TvOS, 1, 0, message: "'offerings' has been renamed to 'getOfferingsWithCompletion:'")]
	[Obsoleted (PlatformName.iOS, 1, 0, message: "'offerings' has been renamed to 'getOfferingsWithCompletion:'")]
	[Export ("offeringsWithCompletionBlock:")]
	void OfferingsWithCompletionBlock (Action<RCOfferings, NSError> completion);

	// -(void)purchasePackage:(RCPackage * _Nonnull)package withCompletionBlock:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, BOOL))completion __attribute__((availability(macos, obsoleted=1))) __attribute__((availability(watchos, obsoleted=1))) __attribute__((availability(tvos, obsoleted=1))) __attribute__((availability(ios, obsoleted=1)));
	[Obsoleted (PlatformName.MacOSX, 1, 0, message: "'purchasePackage' has been renamed to 'purchasePackage:withCompletion:'")]
	[Obsoleted (PlatformName.WatchOS, 1, 0, message: "'purchasePackage' has been renamed to 'purchasePackage:withCompletion:'")]
	[Obsoleted (PlatformName.TvOS, 1, 0, message: "'purchasePackage' has been renamed to 'purchasePackage:withCompletion:'")]
	[Obsoleted (PlatformName.iOS, 1, 0, message: "'purchasePackage' has been renamed to 'purchasePackage:withCompletion:'")]
	[Export ("purchasePackage:withCompletionBlock:")]
	void PurchasePackage (RCPackage package, Action<RCStoreTransaction, RCCustomerInfo, NSError, bool> completion);

	// -(void)purchasePackage:(RCPackage * _Nonnull)package withDiscount:(SKPaymentDiscount * _Nonnull)discount completionBlock:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, BOOL))completion __attribute__((availability(maccatalyst, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(ios, unavailable)));
	[Unavailable (PlatformName.MacCatalyst)]
	[Unavailable (PlatformName.MacOSX)]
	[Unavailable (PlatformName.WatchOS)]
	[Unavailable (PlatformName.TvOS)]
	[Unavailable (PlatformName.iOS)]
	[Export ("purchasePackage:withDiscount:completionBlock:")]
	void PurchasePackage (RCPackage package, SKPaymentDiscount discount, Action<RCStoreTransaction, RCCustomerInfo, NSError, bool> completion);

	// -(void)purchaseProduct:(SKProduct * _Nonnull)product withCompletionBlock:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, BOOL))completion __attribute__((availability(macos, obsoleted=1))) __attribute__((availability(watchos, obsoleted=1))) __attribute__((availability(tvos, obsoleted=1))) __attribute__((availability(ios, obsoleted=1)));
	[Obsoleted (PlatformName.MacOSX, 1, 0, message: "'purchaseProduct' has been renamed to 'purchase(product:_:)'")]
	[Obsoleted (PlatformName.WatchOS, 1, 0, message: "'purchaseProduct' has been renamed to 'purchase(product:_:)'")]
	[Obsoleted (PlatformName.TvOS, 1, 0, message: "'purchaseProduct' has been renamed to 'purchase(product:_:)'")]
	[Obsoleted (PlatformName.iOS, 1, 0, message: "'purchaseProduct' has been renamed to 'purchase(product:_:)'")]
	[Export ("purchaseProduct:withCompletionBlock:")]
	void PurchaseProduct (SKProduct product, Action<RCStoreTransaction, RCCustomerInfo, NSError, bool> completion);

	// -(void)purchaseProduct:(SKProduct * _Nonnull)product withDiscount:(SKPaymentDiscount * _Nonnull)discount completionBlock:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, BOOL))completion __attribute__((availability(maccatalyst, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(ios, unavailable)));
	[Unavailable (PlatformName.MacCatalyst)]
	[Unavailable (PlatformName.MacOSX)]
	[Unavailable (PlatformName.WatchOS)]
	[Unavailable (PlatformName.TvOS)]
	[Unavailable (PlatformName.iOS)]
	[Export ("purchaseProduct:withDiscount:completionBlock:")]
	void PurchaseProduct (SKProduct product, SKPaymentDiscount discount, Action<RCStoreTransaction, RCCustomerInfo, NSError, bool> completion);

	// -(void)invalidatePurchaserInfoCache __attribute__((availability(maccatalyst, obsoleted=1))) __attribute__((availability(macos, obsoleted=1))) __attribute__((availability(watchos, obsoleted=1))) __attribute__((availability(tvos, obsoleted=1))) __attribute__((availability(ios, obsoleted=1)));
	[Obsoleted (PlatformName.MacCatalyst, 1, 0, message: "'invalidatePurchaserInfoCache' has been renamed to 'invalidateCustomerInfoCache'")]
	[Obsoleted (PlatformName.MacOSX, 1, 0, message: "'invalidatePurchaserInfoCache' has been renamed to 'invalidateCustomerInfoCache'")]
	[Obsoleted (PlatformName.WatchOS, 1, 0, message: "'invalidatePurchaserInfoCache' has been renamed to 'invalidateCustomerInfoCache'")]
	[Obsoleted (PlatformName.TvOS, 1, 0, message: "'invalidatePurchaserInfoCache' has been renamed to 'invalidateCustomerInfoCache'")]
	[Obsoleted (PlatformName.iOS, 1, 0, message: "'invalidatePurchaserInfoCache' has been renamed to 'invalidateCustomerInfoCache'")]
	[Export ("invalidatePurchaserInfoCache")]
	void InvalidatePurchaserInfoCache ();

	// -(void)checkTrialOrIntroductoryPriceEligibility:(NSArray<NSString *> * _Nonnull)productIdentifiers completion:(void (^ _Nonnull)(NSDictionary<NSString *,RCIntroEligibility *> * _Nonnull))completion __attribute__((availability(maccatalyst, obsoleted=1))) __attribute__((availability(macos, obsoleted=1))) __attribute__((availability(watchos, obsoleted=1))) __attribute__((availability(tvos, obsoleted=1))) __attribute__((availability(ios, obsoleted=1)));
	[Obsoleted (PlatformName.MacCatalyst, 1, 0, message: "'checkTrialOrIntroductoryPriceEligibility' has been renamed to 'checkTrialOrIntroDiscountEligibility(_:completion:)'")]
	[Obsoleted (PlatformName.MacOSX, 1, 0, message: "'checkTrialOrIntroductoryPriceEligibility' has been renamed to 'checkTrialOrIntroDiscountEligibility(_:completion:)'")]
	[Obsoleted (PlatformName.WatchOS, 1, 0, message: "'checkTrialOrIntroductoryPriceEligibility' has been renamed to 'checkTrialOrIntroDiscountEligibility(_:completion:)'")]
	[Obsoleted (PlatformName.TvOS, 1, 0, message: "'checkTrialOrIntroductoryPriceEligibility' has been renamed to 'checkTrialOrIntroDiscountEligibility(_:completion:)'")]
	[Obsoleted (PlatformName.iOS, 1, 0, message: "'checkTrialOrIntroductoryPriceEligibility' has been renamed to 'checkTrialOrIntroDiscountEligibility(_:completion:)'")]
	[Export ("checkTrialOrIntroductoryPriceEligibility:completion:")]
	void CheckTrialOrIntroductoryPriceEligibility (string[] productIdentifiers, Action<NSDictionary<NSString, RCIntroEligibility>> completion);

	// -(void)paymentDiscountForProductDiscount:(SKProductDiscount * _Nonnull)discount product:(SKProduct * _Nonnull)product completion:(void (^ _Nonnull)(SKPaymentDiscount * _Nullable, NSError * _Nullable))completion __attribute__((availability(maccatalyst, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(ios, unavailable)));
	[Unavailable (PlatformName.MacCatalyst)]
	[Unavailable (PlatformName.MacOSX)]
	[Unavailable (PlatformName.WatchOS)]
	[Unavailable (PlatformName.TvOS)]
	[Unavailable (PlatformName.iOS)]
	[Export ("paymentDiscountForProductDiscount:product:completion:")]
	void PaymentDiscountForProductDiscount (SKProductDiscount discount, SKProduct product, Action<SKPaymentDiscount, NSError> completion);

	// -(void)shouldPurchasePromoProduct:(RCStoreProduct * _Nonnull)product defermentBlock:(void (^ _Nonnull)(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, BOOL)))defermentBlock __attribute__((availability(maccatalyst, obsoleted=1))) __attribute__((availability(macos, obsoleted=1))) __attribute__((availability(watchos, obsoleted=1))) __attribute__((availability(tvos, obsoleted=1))) __attribute__((availability(ios, obsoleted=1)));
	[Obsoleted (PlatformName.MacCatalyst, 1, 0, message: "This was never meant to be public. Use `PurchasesDelegate.purchases(_:readyForPromotedProduct:purchase:)`")]
	[Obsoleted (PlatformName.MacOSX, 1, 0, message: "This was never meant to be public. Use `PurchasesDelegate.purchases(_:readyForPromotedProduct:purchase:)`")]
	[Obsoleted (PlatformName.WatchOS, 1, 0, message: "This was never meant to be public. Use `PurchasesDelegate.purchases(_:readyForPromotedProduct:purchase:)`")]
	[Obsoleted (PlatformName.TvOS, 1, 0, message: "This was never meant to be public. Use `PurchasesDelegate.purchases(_:readyForPromotedProduct:purchase:)`")]
	[Obsoleted (PlatformName.iOS, 1, 0, message: "This was never meant to be public. Use `PurchasesDelegate.purchases(_:readyForPromotedProduct:purchase:)`")]
	[Export ("shouldPurchasePromoProduct:defermentBlock:")]
	void ShouldPurchasePromoProduct (RCStoreProduct product, Action<Action<RCStoreTransaction, RCCustomerInfo, NSError, bool>> defermentBlock);

	// -(void)createAlias:(NSString * _Nonnull)alias completionBlock:(void (^ _Nullable)(RCCustomerInfo * _Nullable, NSError * _Nullable))completion __attribute__((availability(macos, obsoleted=1))) __attribute__((availability(watchos, obsoleted=1))) __attribute__((availability(tvos, obsoleted=1))) __attribute__((availability(ios, obsoleted=1)));
	[Obsoleted (PlatformName.MacOSX, 1, 0, message: "'createAlias' has been renamed to 'logIn:completionHandler:'")]
	[Obsoleted (PlatformName.WatchOS, 1, 0, message: "'createAlias' has been renamed to 'logIn:completionHandler:'")]
	[Obsoleted (PlatformName.TvOS, 1, 0, message: "'createAlias' has been renamed to 'logIn:completionHandler:'")]
	[Obsoleted (PlatformName.iOS, 1, 0, message: "'createAlias' has been renamed to 'logIn:completionHandler:'")]
	[Export ("createAlias:completionBlock:")]
	void CreateAlias (string alias, [NullAllowed] Action<RCCustomerInfo, NSError> completion);

	// -(void)identify:(NSString * _Nonnull)appUserID completionBlock:(void (^ _Nullable)(RCCustomerInfo * _Nullable, NSError * _Nullable))completion __attribute__((availability(macos, obsoleted=1))) __attribute__((availability(watchos, obsoleted=1))) __attribute__((availability(tvos, obsoleted=1))) __attribute__((availability(ios, obsoleted=1)));
	[Obsoleted (PlatformName.MacOSX, 1, 0, message: "'identify' has been renamed to 'logIn:completionHandler:'")]
	[Obsoleted (PlatformName.WatchOS, 1, 0, message: "'identify' has been renamed to 'logIn:completionHandler:'")]
	[Obsoleted (PlatformName.TvOS, 1, 0, message: "'identify' has been renamed to 'logIn:completionHandler:'")]
	[Obsoleted (PlatformName.iOS, 1, 0, message: "'identify' has been renamed to 'logIn:completionHandler:'")]
	[Export ("identify:completionBlock:")]
	void Identify (string appUserID, [NullAllowed] Action<RCCustomerInfo, NSError> completion);

	// -(void)resetWithCompletionBlock:(void (^ _Nullable)(RCCustomerInfo * _Nullable, NSError * _Nullable))completion __attribute__((availability(macos, obsoleted=1))) __attribute__((availability(watchos, obsoleted=1))) __attribute__((availability(tvos, obsoleted=1))) __attribute__((availability(ios, obsoleted=1)));
	[Obsoleted (PlatformName.MacOSX, 1, 0, message: "'reset' has been renamed to 'logOutWithCompletionHandler:'")]
	[Obsoleted (PlatformName.WatchOS, 1, 0, message: "'reset' has been renamed to 'logOutWithCompletionHandler:'")]
	[Obsoleted (PlatformName.TvOS, 1, 0, message: "'reset' has been renamed to 'logOutWithCompletionHandler:'")]
	[Obsoleted (PlatformName.iOS, 1, 0, message: "'reset' has been renamed to 'logOutWithCompletionHandler:'")]
	[Export ("resetWithCompletionBlock:")]
	void ResetWithCompletionBlock ([NullAllowed] Action<RCCustomerInfo, NSError> completion);
}

// @interface RevenueCat_Swift_6229 (RCPurchases)
[Category]
[BaseType (typeof(RCPurchases))]
interface RCPurchases_RevenueCat_Swift_6229
{
	// -(void)getCustomerInfoWithCompletion:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, NSError * _Nullable))completion;
	[Export ("getCustomerInfoWithCompletion:")]
	void GetCustomerInfoWithCompletion (Action<RCCustomerInfo, NSError> completion);

	// -(void)getCustomerInfoWithFetchPolicy:(enum RCCacheFetchPolicy)fetchPolicy completion:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, NSError * _Nullable))completion;
	[Export ("getCustomerInfoWithFetchPolicy:completion:")]
	void GetCustomerInfoWithFetchPolicy (RCCacheFetchPolicy fetchPolicy, Action<RCCustomerInfo, NSError> completion);

	// -(void)customerInfoWithCompletionHandler:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, NSError * _Nullable))completionHandler __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6,2), TV (13,0), Mac (10,15), iOS (13,0)]
	[Export ("customerInfoWithCompletionHandler:")]
	void CustomerInfoWithCompletionHandler (Action<RCCustomerInfo, NSError> completionHandler);

	// -(void)customerInfoWithFetchPolicy:(enum RCCacheFetchPolicy)fetchPolicy completionHandler:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, NSError * _Nullable))completionHandler __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6,2), TV (13,0), Mac (10,15), iOS (13,0)]
	[Export ("customerInfoWithFetchPolicy:completionHandler:")]
	void CustomerInfoWithFetchPolicy (RCCacheFetchPolicy fetchPolicy, Action<RCCustomerInfo, NSError> completionHandler);

	// -(void)getProductsWithIdentifiers:(NSArray<NSString *> * _Nonnull)productIdentifiers completion:(void (^ _Nonnull)(NSArray<RCStoreProduct *> * _Nonnull))completion;
	[Export ("getProductsWithIdentifiers:completion:")]
	void GetProductsWithIdentifiers (string[] productIdentifiers, Action<NSArray<RCStoreProduct>> completion);

	// -(void)products:(NSArray<NSString *> * _Nonnull)productIdentifiers completionHandler:(void (^ _Nonnull)(NSArray<RCStoreProduct *> * _Nonnull))completionHandler __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6,2), TV (13,0), Mac (10,15), iOS (13,0)]
	[Export ("products:completionHandler:")]
	void Products (string[] productIdentifiers, Action<NSArray<RCStoreProduct>> completionHandler);

	// -(void)purchaseProduct:(RCStoreProduct * _Nonnull)product withCompletion:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, BOOL))completion;
	[Export ("purchaseProduct:withCompletion:")]
	void PurchaseProduct (RCStoreProduct product, Action<RCStoreTransaction, RCCustomerInfo, NSError, bool> completion);

	// -(void)purchaseWithProduct:(RCStoreProduct * _Nonnull)product completionHandler:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, BOOL, NSError * _Nullable))completionHandler __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6,2), TV (13,0), Mac (10,15), iOS (13,0)]
	[Export ("purchaseWithProduct:completionHandler:")]
	void PurchaseWithProduct (RCStoreProduct product, Action<RCStoreTransaction, RCCustomerInfo, bool, NSError> completionHandler);

	// -(void)purchasePackage:(RCPackage * _Nonnull)package withCompletion:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, BOOL))completion;
	[Export ("purchasePackage:withCompletion:")]
	void PurchasePackage (RCPackage package, Action<RCStoreTransaction, RCCustomerInfo, NSError, bool> completion);

	// -(void)purchaseWithPackage:(RCPackage * _Nonnull)package completionHandler:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, BOOL, NSError * _Nullable))completionHandler __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6,2), TV (13,0), Mac (10,15), iOS (13,0)]
	[Export ("purchaseWithPackage:completionHandler:")]
	void PurchaseWithPackage (RCPackage package, Action<RCStoreTransaction, RCCustomerInfo, bool, NSError> completionHandler);

	// -(void)syncPurchasesWithCompletion:(void (^ _Nullable)(RCCustomerInfo * _Nullable, NSError * _Nullable))completion;
	[Export ("syncPurchasesWithCompletion:")]
	void SyncPurchasesWithCompletion ([NullAllowed] Action<RCCustomerInfo, NSError> completion);

	// -(void)syncPurchasesWithCompletionHandler:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, NSError * _Nullable))completionHandler __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6,2), TV (13,0), Mac (10,15), iOS (13,0)]
	[Export ("syncPurchasesWithCompletionHandler:")]
	void SyncPurchasesWithCompletionHandler (Action<RCCustomerInfo, NSError> completionHandler);

	// -(void)restorePurchasesWithCompletion:(void (^ _Nullable)(RCCustomerInfo * _Nullable, NSError * _Nullable))completion;
	[Export ("restorePurchasesWithCompletion:")]
	void RestorePurchasesWithCompletion ([NullAllowed] Action<RCCustomerInfo, NSError> completion);

	// -(void)restorePurchasesWithCompletionHandler:(void (^ _Nonnull)(RCCustomerInfo * _Nullable, NSError * _Nullable))completionHandler __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6,2), TV (13,0), Mac (10,15), iOS (13,0)]
	[Export ("restorePurchasesWithCompletionHandler:")]
	void RestorePurchasesWithCompletionHandler (Action<RCCustomerInfo, NSError> completionHandler);

	// -(void)purchaseProduct:(RCStoreProduct * _Nonnull)product withPromotionalOffer:(RCPromotionalOffer * _Nonnull)promotionalOffer completion:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, BOOL))completion __attribute__((availability(tvos, introduced=12.2))) __attribute__((availability(maccatalyst, introduced=13.0))) __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(macos, introduced=10.14.4))) __attribute__((availability(ios, introduced=12.2)));
	//[Watch (6,2), TV (12,2), MacCatalyst (13,0), Mac (10,14,4), iOS (12,2)]
	[Export ("purchaseProduct:withPromotionalOffer:completion:")]
	void PurchaseProduct (RCStoreProduct product, RCPromotionalOffer promotionalOffer, Action<RCStoreTransaction, RCCustomerInfo, NSError, bool> completion);

	// -(void)purchaseWithProduct:(RCStoreProduct * _Nonnull)product promotionalOffer:(RCPromotionalOffer * _Nonnull)promotionalOffer completionHandler:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, BOOL, NSError * _Nullable))completionHandler __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6,2), TV (13,0), Mac (10,15), iOS (13,0)]
	[Export ("purchaseWithProduct:promotionalOffer:completionHandler:")]
	void PurchaseWithProduct (RCStoreProduct product, RCPromotionalOffer promotionalOffer, Action<RCStoreTransaction, RCCustomerInfo, bool, NSError> completionHandler);

	// -(void)purchasePackage:(RCPackage * _Nonnull)package withPromotionalOffer:(RCPromotionalOffer * _Nonnull)promotionalOffer completion:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, BOOL))completion __attribute__((availability(tvos, introduced=12.2))) __attribute__((availability(maccatalyst, introduced=13.0))) __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(macos, introduced=10.14.4))) __attribute__((availability(ios, introduced=12.2)));
	//[Watch (6,2), TV (12,2), MacCatalyst (13,0), Mac (10,14,4), iOS (12,2)]
	[Export ("purchasePackage:withPromotionalOffer:completion:")]
	void PurchasePackage (RCPackage package, RCPromotionalOffer promotionalOffer, Action<RCStoreTransaction, RCCustomerInfo, NSError, bool> completion);

	// -(void)purchaseWithPackage:(RCPackage * _Nonnull)package promotionalOffer:(RCPromotionalOffer * _Nonnull)promotionalOffer completionHandler:(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, BOOL, NSError * _Nullable))completionHandler __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6,2), TV (13,0), Mac (10,15), iOS (13,0)]
	[Export ("purchaseWithPackage:promotionalOffer:completionHandler:")]
	void PurchaseWithPackage (RCPackage package, RCPromotionalOffer promotionalOffer, Action<RCStoreTransaction, RCCustomerInfo, bool, NSError> completionHandler);

	// -(void)checkTrialOrIntroDiscountEligibility:(NSArray<NSString *> * _Nonnull)productIdentifiers completion:(void (^ _Nonnull)(NSDictionary<NSString *,RCIntroEligibility *> * _Nonnull))completion;
	[Export ("checkTrialOrIntroDiscountEligibility:completion:")]
	void CheckTrialOrIntroDiscountEligibility (string[] productIdentifiers, Action<NSDictionary<NSString, RCIntroEligibility>> completion);

	// -(void)checkTrialOrIntroDiscountEligibilityWithProductIdentifiers:(NSArray<NSString *> * _Nonnull)productIdentifiers completionHandler:(void (^ _Nonnull)(NSDictionary<NSString *,RCIntroEligibility *> * _Nonnull))completionHandler __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6,2), TV (13,0), Mac (10,15), iOS (13,0)]
	[Export ("checkTrialOrIntroDiscountEligibilityWithProductIdentifiers:completionHandler:")]
	void CheckTrialOrIntroDiscountEligibilityWithProductIdentifiers (string[] productIdentifiers, Action<NSDictionary<NSString, RCIntroEligibility>> completionHandler);

	// -(void)checkTrialOrIntroDiscountEligibilityForProduct:(RCStoreProduct * _Nonnull)product completion:(void (^ _Nonnull)(enum RCIntroEligibilityStatus))completion;
	[Export ("checkTrialOrIntroDiscountEligibilityForProduct:completion:")]
	void CheckTrialOrIntroDiscountEligibilityForProduct (RCStoreProduct product, Action<RCIntroEligibilityStatus> completion);

	// -(void)checkTrialOrIntroDiscountEligibilityWithProduct:(RCStoreProduct * _Nonnull)product completionHandler:(void (^ _Nonnull)(enum RCIntroEligibilityStatus))completionHandler __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6,2), TV (13,0), Mac (10,15), iOS (13,0)]
	[Export ("checkTrialOrIntroDiscountEligibilityWithProduct:completionHandler:")]
	void CheckTrialOrIntroDiscountEligibilityWithProduct (RCStoreProduct product, Action<RCIntroEligibilityStatus> completionHandler);

	// -(void)showPriceConsentIfNeeded __attribute__((availability(maccatalyst, introduced=13.4))) __attribute__((availability(ios, introduced=13.4)));
	//[MacCatalyst (13,4), iOS (13,4)]
	[Export ("showPriceConsentIfNeeded")]
	void ShowPriceConsentIfNeeded ();

	// -(void)invalidateCustomerInfoCache;
	[Export ("invalidateCustomerInfoCache")]
	void InvalidateCustomerInfoCache ();

	// -(void)presentCodeRedemptionSheet __attribute__((availability(maccatalyst, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(ios, introduced=14.0)));
	//[NoWatch, NoTV, NoMacCatalyst, NoMac, iOS (14,0)]
	[Export ("presentCodeRedemptionSheet")]
	void PresentCodeRedemptionSheet ();

	// -(void)getPromotionalOfferForProductDiscount:(RCStoreProductDiscount * _Nonnull)discount withProduct:(RCStoreProduct * _Nonnull)product withCompletion:(void (^ _Nonnull)(RCPromotionalOffer * _Nullable, NSError * _Nullable))completion __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=12.2))) __attribute__((availability(maccatalyst, introduced=13.0))) __attribute__((availability(macos, introduced=10.14.4))) __attribute__((availability(ios, introduced=12.2)));
	//[Watch (6,2), TV (12,2), MacCatalyst (13,0), Mac (10,14,4), iOS (12,2)]
	[Export ("getPromotionalOfferForProductDiscount:withProduct:withCompletion:")]
	void GetPromotionalOfferForProductDiscount (RCStoreProductDiscount discount, RCStoreProduct product, Action<RCPromotionalOffer, NSError> completion);

	// -(void)promotionalOfferForProductDiscount:(RCStoreProductDiscount * _Nonnull)discount product:(RCStoreProduct * _Nonnull)product completionHandler:(void (^ _Nonnull)(RCPromotionalOffer * _Nullable, NSError * _Nullable))completionHandler __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch(6,2), TV (13,0), Mac (10,15), iOS (13,0)]
	[Export ("promotionalOfferForProductDiscount:product:completionHandler:")]
	void PromotionalOfferForProductDiscount (RCStoreProductDiscount discount, RCStoreProduct product, Action<RCPromotionalOffer, NSError> completionHandler);

	// -(void)eligiblePromotionalOffersForProduct:(RCStoreProduct * _Nonnull)product completionHandler:(void (^ _Nonnull)(NSArray<RCPromotionalOffer *> * _Nonnull))completionHandler __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6,2), TV (13,0), Mac (10,15), iOS (13,0)]
	[Export ("eligiblePromotionalOffersForProduct:completionHandler:")]
	void EligiblePromotionalOffersForProduct (RCStoreProduct product, Action<NSArray<RCPromotionalOffer>> completionHandler);

	// -(void)showManageSubscriptionsWithCompletion:(void (^ _Nonnull)(NSError * _Nullable))completion __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable)));
	//[NoWatch, NoTV, Mac (10,15), iOS (13,0)]
	[Export ("showManageSubscriptionsWithCompletion:")]
	void ShowManageSubscriptionsWithCompletion (Action<NSError> completion);

	// -(void)showManageSubscriptionsWithCompletionHandler:(void (^ _Nonnull)(NSError * _Nullable))completionHandler __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable)));
	//[NoWatch, NoTV, Mac (10,15), iOS (13,0)]
	[Export ("showManageSubscriptionsWithCompletionHandler:")]
	void ShowManageSubscriptionsWithCompletionHandler (Action<NSError> completionHandler);

	// -(void)beginRefundRequestForProduct:(NSString * _Nonnull)productID completion:(void (^ _Nonnull)(enum RCRefundRequestStatus, NSError * _Nullable))completionHandler __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(ios, introduced=15.0)));
	//[NoWatch, NoTV, NoMac, iOS (15,0)]
	[Export ("beginRefundRequestForProduct:completion:")]
	void BeginRefundRequestForProduct (string productID, Action<RCRefundRequestStatus, NSError> completionHandler);

	// -(void)beginRefundRequestForEntitlement:(NSString * _Nonnull)entitlementID completion:(void (^ _Nonnull)(enum RCRefundRequestStatus, NSError * _Nullable))completionHandler __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(ios, introduced=15.0)));
	//[NoWatch, NoTV, NoMac, iOS (15,0)]
	[Export ("beginRefundRequestForEntitlement:completion:")]
	void BeginRefundRequestForEntitlement (string entitlementID, Action<RCRefundRequestStatus, NSError> completionHandler);

	// -(void)beginRefundRequestForActiveEntitlementWithCompletion:(void (^ _Nonnull)(enum RCRefundRequestStatus, NSError * _Nullable))completionHandler __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(ios, introduced=15.0)));
	//[NoWatch, NoTV, NoMac, iOS (15,0)]
	[Export ("beginRefundRequestForActiveEntitlementWithCompletion:")]
	void BeginRefundRequestForActiveEntitlementWithCompletion (Action<RCRefundRequestStatus, NSError> completionHandler);
}

// @protocol RCPurchasesDelegate <NSObject>
[Protocol, Model/* (AutoGeneratedName = true)*/]
[BaseType (typeof(NSObject))]
interface RCPurchasesDelegate
{
	// @optional -(void)purchases:(RCPurchases * _Nonnull)purchases didReceiveUpdatedPurchaserInfo:(RCCustomerInfo * _Nonnull)purchaserInfo __attribute__((availability(watchos, obsoleted=1))) __attribute__((availability(tvos, obsoleted=1))) __attribute__((availability(macos, obsoleted=1))) __attribute__((availability(ios, obsoleted=1)));
	[Obsoleted (PlatformName.WatchOS, 1, 0)]
	[Obsoleted (PlatformName.TvOS, 1, 0)]
	[Obsoleted (PlatformName.MacOSX, 1, 0)]
	[Obsoleted (PlatformName.iOS, 1, 0)]
	[Export ("purchases:didReceiveUpdatedPurchaserInfo:")]
	void DidReceiveUpdatedPurchaserInfo (RCPurchases purchases, RCCustomerInfo purchaserInfo);

	// @optional -(void)purchases:(RCPurchases * _Nonnull)purchases receivedUpdatedCustomerInfo:(RCCustomerInfo * _Nonnull)customerInfo;
	[Export ("purchases:receivedUpdatedCustomerInfo:")]
	void ReceivedUpdatedCustomerInfo (RCPurchases purchases, RCCustomerInfo customerInfo);

	// @optional -(void)purchases:(RCPurchases * _Nonnull)purchases readyForPromotedProduct:(RCStoreProduct * _Nonnull)product purchase:(void (^ _Nonnull)(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, BOOL)))startPurchase;
	[Export ("purchases:readyForPromotedProduct:purchase:")]
	void ReadyForPromotedProduct (RCPurchases purchases, RCStoreProduct product, Action<Action<RCStoreTransaction, RCCustomerInfo, NSError, bool>> startPurchase);

	// @optional -(void)purchases:(RCPurchases * _Nonnull)purchases shouldPurchasePromoProduct:(RCStoreProduct * _Nonnull)product defermentBlock:(void (^ _Nonnull)(void (^ _Nonnull)(RCStoreTransaction * _Nullable, RCCustomerInfo * _Nullable, NSError * _Nullable, BOOL)))makeDeferredPurchase __attribute__((availability(maccatalyst, obsoleted=1))) __attribute__((availability(macos, obsoleted=1))) __attribute__((availability(watchos, obsoleted=1))) __attribute__((availability(tvos, obsoleted=1))) __attribute__((availability(ios, obsoleted=1)));
	[Obsoleted (PlatformName.MacCatalyst, 1, 0, message: "'purchases' has been renamed to 'purchases:readyForPromotedProduct:purchase:'")]
	[Obsoleted (PlatformName.MacOSX, 1, 0, message: "'purchases' has been renamed to 'purchases:readyForPromotedProduct:purchase:'")]
	[Obsoleted (PlatformName.WatchOS, 1, 0, message: "'purchases' has been renamed to 'purchases:readyForPromotedProduct:purchase:'")]
	[Obsoleted (PlatformName.TvOS, 1, 0, message: "'purchases' has been renamed to 'purchases:readyForPromotedProduct:purchase:'")]
	[Obsoleted (PlatformName.iOS, 1, 0, message: "'purchases' has been renamed to 'purchases:readyForPromotedProduct:purchase:'")]
	[Export ("purchases:shouldPurchasePromoProduct:defermentBlock:")]
	void ShouldPurchasePromoProduct (RCPurchases purchases, RCStoreProduct product, Action<Action<RCStoreTransaction, RCCustomerInfo, NSError, bool>> makeDeferredPurchase);

	// @optional @property (readonly, nonatomic) BOOL shouldShowPriceConsent __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(macos, unavailable))) __attribute__((availability(maccatalyst, introduced=13.4))) __attribute__((availability(ios, introduced=13.4)));
	//[NoWatch, NoTV, NoMac, MacCatalyst (13, 4), iOS (13, 4)]
	[Export ("shouldShowPriceConsent")]
	bool ShouldShowPriceConsent { get; }
}

// @interface RCPurchasesDiagnostics : NSObject
//[Watch (6,2), TV (13,0), Mac (10,15), iOS (13,0)]
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface RCPurchasesDiagnostics
{
	// @property (readonly, getter = default, nonatomic, strong, class) RCPurchasesDiagnostics * _Nonnull default_;
	[Static]
	[Export ("default_", ArgumentSemantic.Strong)]
	RCPurchasesDiagnostics Default_ { [Bind ("default")] get; }
}

// @interface RevenueCat_Swift_6347 (RCPurchasesDiagnostics)
//[Watch (6,2), TV (13,0), Mac (10,15), iOS (13,0)]
[Category]
[BaseType (typeof(RCPurchasesDiagnostics))]
interface RCPurchasesDiagnostics_RevenueCat_Swift_6347
{
	// -(void)testSDKHealthWithCompletion:(void (^ _Nonnull)(NSError * _Nullable))completionHandler;
	[Export ("testSDKHealthWithCompletion:")]
	void TestSDKHealthWithCompletion (Action<NSError> completionHandler);
}

// @interface PurchasesReceiptParser : NSObject
[BaseType (typeof(NSObject), Name = "_TtC10RevenueCat22PurchasesReceiptParser")]
[DisableDefaultCtor]
interface PurchasesReceiptParser
{
}

// @interface RevenueCat_Swift_6377 (PurchasesReceiptParser)
[Category]
[BaseType (typeof(PurchasesReceiptParser))]
interface PurchasesReceiptParser_RevenueCat_Swift_6377
{
	// -(BOOL)receiptHasTransactionsWithReceiptData:(NSData * _Nonnull)receiptData __attribute__((warn_unused_result("")));
	[Export ("receiptHasTransactionsWithReceiptData:")]
	bool ReceiptHasTransactionsWithReceiptData (NSData receiptData);
}

// @interface RevenueCat_Swift_6384 (PurchasesReceiptParser)
[Category]
[BaseType (typeof(PurchasesReceiptParser))]
interface PurchasesReceiptParser_RevenueCat_Swift_6384
{
	// @property (readonly, getter = default, nonatomic, strong, class) PurchasesReceiptParser * _Nonnull default_;
	[Static]
	[Export ("default_", ArgumentSemantic.Strong)]
	PurchasesReceiptParser Default_ { [Bind ("default")] get; }
}

// @interface RCPurchasesErrorUtils : NSObject
[Obsoleted (PlatformName.MacCatalyst, 1, 0)]
[Obsoleted (PlatformName.MacOSX, 1, 0)]
[Obsoleted (PlatformName.WatchOS, 1, 0)]
[Obsoleted (PlatformName.TvOS, 1, 0)]
[Obsoleted (PlatformName.iOS, 1, 0)]
[BaseType (typeof(NSObject), Name = "_TtC10RevenueCat21RCPurchasesErrorUtils")]
interface RCPurchasesErrorUtils
{
}

// @interface RedirectLoggerSessionDelegate : NSObject <NSURLSessionTaskDelegate>
[BaseType (typeof(NSObject), Name = "_TtC10RevenueCat29RedirectLoggerSessionDelegate")]
interface RedirectLoggerSessionDelegate : INSUrlSessionTaskDelegate
{
	// -(void)URLSession:(NSURLSession * _Nonnull)session task:(NSURLSessionTask * _Nonnull)task willPerformHTTPRedirection:(NSHTTPURLResponse * _Nonnull)response newRequest:(NSURLRequest * _Nonnull)request completionHandler:(void (^ _Nonnull)(NSURLRequest * _Nullable))completionHandler;
	[Export ("URLSession:task:willPerformHTTPRedirection:newRequest:completionHandler:")]
	void URLSession (NSUrlSession session, NSUrlSessionTask task, NSHttpUrlResponse response, NSUrlRequest request, Action<NSURLRequest> completionHandler);
}

// @interface StoreKit1Wrapper : NSObject
[BaseType (typeof(NSObject), Name = "_TtC10RevenueCat16StoreKit1Wrapper")]
[DisableDefaultCtor]
interface StoreKit1Wrapper
{
	// @property (readonly, nonatomic, strong) RCStorefront * _Nullable currentStorefront;
	[NullAllowed, Export ("currentStorefront", ArgumentSemantic.Strong)]
	RCStorefront CurrentStorefront { get; }
}

// @interface RevenueCat_Swift_6454 (StoreKit1Wrapper) <SKPaymentQueueDelegate>
[Category]
[BaseType (typeof(StoreKit1Wrapper))]
interface StoreKit1Wrapper_RevenueCat_Swift_6454 : ISKPaymentQueueDelegate
{
	// -(BOOL)paymentQueueShouldShowPriceConsent:(SKPaymentQueue * _Nonnull)paymentQueue __attribute__((warn_unused_result(""))) __attribute__((availability(maccatalyst, introduced=13.4))) __attribute__((availability(ios, introduced=13.4)));
	//[MacCatalyst (13,4), iOS (13,4)]
	[Export ("paymentQueueShouldShowPriceConsent:")]
	bool PaymentQueueShouldShowPriceConsent (SKPaymentQueue paymentQueue);
}

// @interface RevenueCat_Swift_6459 (StoreKit1Wrapper) <PaymentQueueWrapperType>
[Category]
[BaseType (typeof(StoreKit1Wrapper))]
interface StoreKit1Wrapper_RevenueCat_Swift_6459 : IPaymentQueueWrapperType
{
	// -(void)finishTransaction:(SKPaymentTransaction * _Nonnull)transaction completion:(void (^ _Nonnull)(void))completion;
	[Export ("finishTransaction:completion:")]
	void FinishTransaction (SKPaymentTransaction transaction, Action completion);

	// -(void)showPriceConsentIfNeeded __attribute__((availability(maccatalyst, introduced=13.4))) __attribute__((availability(ios, introduced=13.4)));
	//[MacCatalyst (13,4), iOS (13,4)]
	[Export ("showPriceConsentIfNeeded")]
	void ShowPriceConsentIfNeeded ();

	// -(void)presentCodeRedemptionSheet __attribute__((availability(ios, introduced=14.0)));
	//[iOS (14,0)]
	[Export ("presentCodeRedemptionSheet")]
	void PresentCodeRedemptionSheet ();
}

// @interface RevenueCat_Swift_6466 (StoreKit1Wrapper) <SKPaymentTransactionObserver>
[Category]
[BaseType (typeof(StoreKit1Wrapper))]
interface StoreKit1Wrapper_RevenueCat_Swift_6466 : ISKPaymentTransactionObserver
{
	// -(void)paymentQueue:(SKPaymentQueue * _Nonnull)queue updatedTransactions:(NSArray<SKPaymentTransaction *> * _Nonnull)transactions;
	[Export ("paymentQueue:updatedTransactions:")]
	void PaymentQueue (SKPaymentQueue queue, SKPaymentTransaction[] transactions);

	// -(void)paymentQueue:(SKPaymentQueue * _Nonnull)queue removedTransactions:(NSArray<SKPaymentTransaction *> * _Nonnull)transactions;
	[Export ("paymentQueue:removedTransactions:")]
	void PaymentQueue (SKPaymentQueue queue, SKPaymentTransaction[] transactions);

	// -(BOOL)paymentQueue:(SKPaymentQueue * _Nonnull)queue shouldAddStorePayment:(SKPayment * _Nonnull)payment forProduct:(SKProduct * _Nonnull)product __attribute__((swift_name("paymentQueue(_:shouldAddStorePayment:for:)"))) __attribute__((warn_unused_result("")));
	[Export ("paymentQueue:shouldAddStorePayment:forProduct:")]
	bool PaymentQueue (SKPaymentQueue queue, SKPayment payment, SKProduct product);

	// -(void)paymentQueue:(SKPaymentQueue * _Nonnull)queue didRevokeEntitlementsForProductIdentifiers:(NSArray<NSString *> * _Nonnull)productIdentifiers __attribute__((swift_name("paymentQueue(_:didRevokeEntitlementsForProductIdentifiers:)"))) __attribute__((availability(watchos, introduced=7.0))) __attribute__((availability(tvos, introduced=14.0))) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, introduced=14.0)));
	//[Watch (7,0), TV (14,0), Mac (11,0), iOS (14,0)]
	[Export ("paymentQueue:didRevokeEntitlementsForProductIdentifiers:")]
	void PaymentQueue (SKPaymentQueue queue, string[] productIdentifiers);

	// -(void)paymentQueueDidChangeStorefront:(SKPaymentQueue * _Nonnull)queue;
	[Export ("paymentQueueDidChangeStorefront:")]
	void PaymentQueueDidChangeStorefront (SKPaymentQueue queue);
}

// @interface StoreKitRequestFetcher : NSObject
[BaseType (typeof(NSObject), Name = "_TtC10RevenueCat22StoreKitRequestFetcher")]
[DisableDefaultCtor]
interface StoreKitRequestFetcher
{
}

// @interface RevenueCat_Swift_6484 (StoreKitRequestFetcher) <SKRequestDelegate>
[Category]
[BaseType (typeof(StoreKitRequestFetcher))]
interface StoreKitRequestFetcher_RevenueCat_Swift_6484 : ISKRequestDelegate
{
	// -(void)requestDidFinish:(SKRequest * _Nonnull)request;
	[Export ("requestDidFinish:")]
	void RequestDidFinish (SKRequest request);

	// -(void)request:(SKRequest * _Nonnull)request didFailWithError:(NSError * _Nonnull)error;
	[Export ("request:didFailWithError:")]
	void Request (SKRequest request, NSError error);
}

// @interface RCStoreProduct : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface RCStoreProduct
{
	// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
	[Export ("isEqual:")]
	bool IsEqual ([NullAllowed] NSObject @object);

	// @property (readonly, nonatomic) NSUInteger hash;
	[Export ("hash")]
	nuint Hash { get; }

	// @property (readonly, nonatomic) enum RCStoreProductType productType;
	[Export ("productType")]
	RCStoreProductType ProductType { get; }

	// @property (readonly, nonatomic) enum RCStoreProductCategory productCategory;
	[Export ("productCategory")]
	RCStoreProductCategory ProductCategory { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull localizedDescription;
	[Export ("localizedDescription")]
	string LocalizedDescription { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull localizedTitle;
	[Export ("localizedTitle")]
	string LocalizedTitle { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nullable currencyCode;
	[NullAllowed, Export ("currencyCode")]
	string CurrencyCode { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull localizedPriceString;
	[Export ("localizedPriceString")]
	string LocalizedPriceString { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull productIdentifier;
	[Export ("productIdentifier")]
	string ProductIdentifier { get; }

	// @property (readonly, nonatomic) BOOL isFamilyShareable __attribute__((availability(watchos, introduced=7.0))) __attribute__((availability(tvos, introduced=14.0))) __attribute__((availability(macos, introduced=11.0))) __attribute__((availability(ios, introduced=14.0)));
	//[Watch (7, 0), TV (14, 0), Mac (11, 0), iOS (14, 0)]
	[Export ("isFamilyShareable")]
	bool IsFamilyShareable { get; }

	// @property (readonly, copy, nonatomic) SWIFT_AVAILABILITY(watchos,introduced=6.2) NSString * subscriptionGroupIdentifier __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(macos, introduced=10.14))) __attribute__((availability(tvos, introduced=12.0))) __attribute__((availability(maccatalyst, introduced=13.0))) __attribute__((availability(ios, introduced=12.0)));
	//[Watch (6, 2), TV (12, 0), MacCatalyst (13, 0), Mac (10, 14), iOS (12, 0)]
	[Export ("subscriptionGroupIdentifier")]
	string SubscriptionGroupIdentifier { get; }

	// @property (readonly, nonatomic, strong) NSNumberFormatter * _Nullable priceFormatter;
	[NullAllowed, Export ("priceFormatter", ArgumentSemantic.Strong)]
	NSNumberFormatter PriceFormatter { get; }

	// @property (readonly, nonatomic, strong) SWIFT_AVAILABILITY(watchos,introduced=6.2) RCSubscriptionPeriod * subscriptionPeriod __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=11.2))) __attribute__((availability(macos, introduced=10.13.2))) __attribute__((availability(ios, introduced=11.2)));
	//[Watch (6, 2), TV (11, 2), Mac (10, 13, 2), iOS (11, 2)]
	[Export ("subscriptionPeriod", ArgumentSemantic.Strong)]
	RCSubscriptionPeriod SubscriptionPeriod { get; }

	// @property (readonly, nonatomic, strong) SWIFT_AVAILABILITY(watchos,introduced=6.2) RCStoreProductDiscount * introductoryDiscount __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=11.2))) __attribute__((availability(macos, introduced=10.13.2))) __attribute__((availability(ios, introduced=11.2)));
	//[Watch (6, 2), TV (11, 2), Mac (10, 13, 2), iOS (11, 2)]
	[Export ("introductoryDiscount", ArgumentSemantic.Strong)]
	RCStoreProductDiscount IntroductoryDiscount { get; }

	// @property (readonly, copy, nonatomic) SWIFT_AVAILABILITY(watchos,introduced=6.2) NSArray<RCStoreProductDiscount *> * discounts __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=12.2))) __attribute__((availability(macos, introduced=10.14.4))) __attribute__((availability(ios, introduced=12.2)));
	//[Watch (6, 2), TV (12, 2), Mac (10, 14, 4), iOS (12, 2)]
	[Export ("discounts", ArgumentSemantic.Copy)]
	RCStoreProductDiscount[] Discounts { get; }
}

// @interface RevenueCat_Swift_6519 (RCStoreProduct)
[Category]
[BaseType (typeof(RCStoreProduct))]
interface RCStoreProduct_RevenueCat_Swift_6519
{
}

// @interface RevenueCat_Swift_6556 (RCStoreProduct)
[Category]
[BaseType (typeof(RCStoreProduct))]
interface RCStoreProduct_RevenueCat_Swift_6556
{
	// @property (readonly, nonatomic, strong) SWIFT_AVAILABILITY(macos,unavailable,message="'introductoryPrice' has been renamed to 'introductoryDiscount': Use StoreProductDiscount instead") SKProductDiscount * introductoryPrice __attribute__((availability(macos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(ios, unavailable)));
	[Unavailable (PlatformName.MacOSX)]
	[Unavailable (PlatformName.WatchOS)]
	[Unavailable (PlatformName.TvOS)]
	[Unavailable (PlatformName.iOS)]
	[Export ("introductoryPrice", ArgumentSemantic.Strong)]
	SKProductDiscount IntroductoryPrice { get; }

	// @property (readonly, copy, nonatomic) SWIFT_AVAILABILITY(macos,unavailable,message="Use localizedPriceString instead") NSLocale * priceLocale __attribute__((availability(macos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(ios, unavailable)));
	[Unavailable (PlatformName.MacOSX)]
	[Unavailable (PlatformName.WatchOS)]
	[Unavailable (PlatformName.TvOS)]
	[Unavailable (PlatformName.iOS)]
	[Export ("priceLocale", ArgumentSemantic.Copy)]
	NSLocale PriceLocale { get; }
}

// @interface RevenueCat_Swift_6564 (RCStoreProduct)
[Category]
[BaseType (typeof(RCStoreProduct))]
interface RCStoreProduct_RevenueCat_Swift_6564
{
	// -(instancetype _Nonnull)initWithSk1Product:(SKProduct * _Nonnull)sk1Product;
	[Export ("initWithSk1Product:")]
	NativeHandle Constructor (SKProduct sk1Product);

	// @property (readonly, nonatomic, strong) SKProduct * _Nullable sk1Product;
	[NullAllowed, Export ("sk1Product", ArgumentSemantic.Strong)]
	SKProduct Sk1Product { get; }
}

// @interface RevenueCat_Swift_6572 (RCStoreProduct)
[Category]
[BaseType (typeof(RCStoreProduct))]
interface RCStoreProduct_RevenueCat_Swift_6572
{
	// @property (readonly, nonatomic, strong) NSDecimalNumber * _Nonnull price;
	[Export ("price", ArgumentSemantic.Strong)]
	NSDecimalNumber Price { get; }

	// @property (readonly, nonatomic, strong) SWIFT_AVAILABILITY(watchos,introduced=6.2) NSDecimalNumber * pricePerMonth __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=11.2))) __attribute__((availability(macos, introduced=10.13.2))) __attribute__((availability(ios, introduced=11.2)));
	//[Watch (6, 2), TV (11, 2), Mac (10, 13, 2), iOS (11, 2)]
	[Export ("pricePerMonth", ArgumentSemantic.Strong)]
	NSDecimalNumber PricePerMonth { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nullable localizedIntroductoryPriceString;
	[NullAllowed, Export ("localizedIntroductoryPriceString")]
	string LocalizedIntroductoryPriceString { get; }
}

// @interface RCStoreProductDiscount : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface RCStoreProductDiscount
{
	// @property (readonly, copy, nonatomic) NSString * _Nullable offerIdentifier;
	[NullAllowed, Export ("offerIdentifier")]
	string OfferIdentifier { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nullable currencyCode;
	[NullAllowed, Export ("currencyCode")]
	string CurrencyCode { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull localizedPriceString;
	[Export ("localizedPriceString")]
	string LocalizedPriceString { get; }

	// @property (readonly, nonatomic) enum RCPaymentMode paymentMode;
	[Export ("paymentMode")]
	RCPaymentMode PaymentMode { get; }

	// @property (readonly, nonatomic, strong) RCSubscriptionPeriod * _Nonnull subscriptionPeriod;
	[Export ("subscriptionPeriod", ArgumentSemantic.Strong)]
	RCSubscriptionPeriod SubscriptionPeriod { get; }

	// @property (readonly, nonatomic) NSInteger numberOfPeriods;
	[Export ("numberOfPeriods")]
	nint NumberOfPeriods { get; }

	// @property (readonly, nonatomic) enum RCDiscountType type;
	[Export ("type")]
	RCDiscountType Type { get; }

	// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
	[Export ("isEqual:")]
	bool IsEqual ([NullAllowed] NSObject @object);

	// @property (readonly, nonatomic) NSUInteger hash;
	[Export ("hash")]
	nuint Hash { get; }
}

// @interface RevenueCat_Swift_6642 (RCStoreProductDiscount)
[Category]
[BaseType (typeof(RCStoreProductDiscount))]
interface RCStoreProductDiscount_RevenueCat_Swift_6642
{
	// @property (readonly, nonatomic, strong) NSDecimalNumber * _Nonnull price;
	[Export ("price", ArgumentSemantic.Strong)]
	NSDecimalNumber Price { get; }
}

// @interface RevenueCat_Swift_6652 (RCStoreProductDiscount)
[Category]
[BaseType (typeof(RCStoreProductDiscount))]
interface RCStoreProductDiscount_RevenueCat_Swift_6652
{
	// @property (readonly, nonatomic, strong) SWIFT_AVAILABILITY(watchos,introduced=6.2) SKProductDiscount * sk1Discount __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=12.2))) __attribute__((availability(macos, introduced=10.14.4))) __attribute__((availability(ios, introduced=12.2)));
	//[Watch (6, 2), TV (12, 2), Mac (10, 14, 4), iOS (12, 2)]
	[Export ("sk1Discount", ArgumentSemantic.Strong)]
	SKProductDiscount Sk1Discount { get; }
}

// @interface RCStoreTransaction : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface RCStoreTransaction
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull productIdentifier;
	[Export ("productIdentifier")]
	string ProductIdentifier { get; }

	// @property (readonly, copy, nonatomic) NSDate * _Nonnull purchaseDate;
	[Export ("purchaseDate", ArgumentSemantic.Copy)]
	NSDate PurchaseDate { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull transactionIdentifier;
	[Export ("transactionIdentifier")]
	string TransactionIdentifier { get; }

	// @property (readonly, nonatomic) NSInteger quantity;
	[Export ("quantity")]
	nint Quantity { get; }

	// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
	[Export ("isEqual:")]
	bool IsEqual ([NullAllowed] NSObject @object);

	// @property (readonly, nonatomic) NSUInteger hash;
	[Export ("hash")]
	nuint Hash { get; }
}

// @interface RevenueCat_Swift_6675 (RCStoreTransaction)
[Category]
[BaseType (typeof(RCStoreTransaction))]
interface RCStoreTransaction_RevenueCat_Swift_6675
{
	// @property (readonly, copy, nonatomic) SWIFT_AVAILABILITY(macos,obsoleted=1,message="'productId' has been renamed to 'productIdentifier'") NSString * productId __attribute__((availability(macos, obsoleted=1))) __attribute__((availability(watchos, obsoleted=1))) __attribute__((availability(tvos, obsoleted=1))) __attribute__((availability(ios, obsoleted=1)));
	[Obsoleted (PlatformName.MacOSX, 1, 0, message: "'productId' has been renamed to 'productIdentifier'")]
	[Obsoleted (PlatformName.WatchOS, 1, 0, message: "'productId' has been renamed to 'productIdentifier'")]
	[Obsoleted (PlatformName.TvOS, 1, 0, message: "'productId' has been renamed to 'productIdentifier'")]
	[Obsoleted (PlatformName.iOS, 1, 0, message: "'productId' has been renamed to 'productIdentifier'")]
	[Export ("productId")]
	string ProductId { get; }

	// @property (readonly, copy, nonatomic) SWIFT_AVAILABILITY(macos,obsoleted=1,message="'revenueCatId' has been renamed to 'transactionIdentifier'") NSString * revenueCatId __attribute__((availability(macos, obsoleted=1))) __attribute__((availability(watchos, obsoleted=1))) __attribute__((availability(tvos, obsoleted=1))) __attribute__((availability(ios, obsoleted=1)));
	[Obsoleted (PlatformName.MacOSX, 1, 0, message: "'revenueCatId' has been renamed to 'transactionIdentifier'")]
	[Obsoleted (PlatformName.WatchOS, 1, 0, message: "'revenueCatId' has been renamed to 'transactionIdentifier'")]
	[Obsoleted (PlatformName.TvOS, 1, 0, message: "'revenueCatId' has been renamed to 'transactionIdentifier'")]
	[Obsoleted (PlatformName.iOS, 1, 0, message: "'revenueCatId' has been renamed to 'transactionIdentifier'")]
	[Export ("revenueCatId")]
	string RevenueCatId { get; }
}

// @interface RevenueCat_Swift_6681 (RCStoreTransaction)
[Category]
[BaseType (typeof(RCStoreTransaction))]
interface RCStoreTransaction_RevenueCat_Swift_6681
{
	// @property (readonly, nonatomic, strong) SKPaymentTransaction * _Nullable sk1Transaction;
	[NullAllowed, Export ("sk1Transaction", ArgumentSemantic.Strong)]
	SKPaymentTransaction Sk1Transaction { get; }
}

// @interface RCStorefront : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface RCStorefront
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull countryCode;
	[Export ("countryCode")]
	string CountryCode { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull identifier;
	[Export ("identifier")]
	string Identifier { get; }

	// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
	[Export ("isEqual:")]
	bool IsEqual ([NullAllowed] NSObject @object);

	// @property (readonly, nonatomic) NSUInteger hash;
	[Export ("hash")]
	nuint Hash { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
	[Export ("description")]
	string Description { get; }
}

// @interface RevenueCat_Swift_6707 (RCStorefront)
[Category]
[BaseType (typeof(RCStorefront))]
interface RCStorefront_RevenueCat_Swift_6707
{
	// @property (readonly, nonatomic, strong) SWIFT_AVAILABILITY(maccatalyst,introduced=13.1) SKStorefront * sk1Storefront __attribute__((availability(maccatalyst, introduced=13.1))) __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6, 2), TV (13, 0), MacCatalyst (13, 1), Mac (10, 15), iOS (13, 0)]
	[Export ("sk1Storefront", ArgumentSemantic.Strong)]
	SKStorefront Sk1Storefront { get; }
}

// @interface RevenueCat_Swift_6713 (RCStorefront)
[Category]
[BaseType (typeof(RCStorefront))]
interface RCStorefront_RevenueCat_Swift_6713
{
	// @property (readonly, nonatomic, strong, class) RCStorefront * _Nullable sk1CurrentStorefront __attribute__((availability(maccatalyst, introduced=13.1))) __attribute__((availability(watchos, introduced=6.2))) __attribute__((availability(tvos, introduced=13.0))) __attribute__((availability(macos, introduced=10.15))) __attribute__((availability(ios, introduced=13.0)));
	//[Watch (6, 2), TV (13, 0), MacCatalyst (13, 1), Mac (10, 15), iOS (13, 0)]
	[Static]
	[NullAllowed, Export ("sk1CurrentStorefront", ArgumentSemantic.Strong)]
	RCStorefront Sk1CurrentStorefront { get; }
}

// @interface RCSubscriptionPeriod : NSObject
[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface RCSubscriptionPeriod
{
	// @property (readonly, nonatomic) NSInteger value;
	[Export ("value")]
	nint Value { get; }

	// @property (readonly, nonatomic) enum RCSubscriptionPeriodUnit unit;
	[Export ("unit")]
	RCSubscriptionPeriodUnit Unit { get; }

	// -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
	[Export ("isEqual:")]
	bool IsEqual ([NullAllowed] NSObject @object);

	// @property (readonly, nonatomic) NSUInteger hash;
	[Export ("hash")]
	nuint Hash { get; }
}

// @interface RevenueCat_Swift_6752 (RCSubscriptionPeriod)
[Category]
[BaseType (typeof(RCSubscriptionPeriod))]
interface RCSubscriptionPeriod_RevenueCat_Swift_6752
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
	[Export ("debugDescription")]
	string DebugDescription { get; }
}

// @interface RevenueCat_Swift_6757 (RCSubscriptionPeriod)
[Category]
[BaseType (typeof(RCSubscriptionPeriod))]
interface RCSubscriptionPeriod_RevenueCat_Swift_6757
{
	// @property (readonly, nonatomic) NSInteger numberOfUnits __attribute__((availability(macos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(ios, unavailable)));
	[Unavailable (PlatformName.MacOSX)]
	[Unavailable (PlatformName.WatchOS)]
	[Unavailable (PlatformName.TvOS)]
	[Unavailable (PlatformName.iOS)]
	[Export ("numberOfUnits")]
	nint NumberOfUnits { get; }
}

// @interface TrackingManagerProxy : NSObject
[BaseType (typeof(NSObject), Name = "_TtC10RevenueCat20TrackingManagerProxy")]
interface TrackingManagerProxy
{
	// @property (readonly, copy, nonatomic) NSString * _Nonnull authorizationStatusPropertyName;
	[Export ("authorizationStatusPropertyName")]
	string AuthorizationStatusPropertyName { get; }

	// -(NSInteger)trackingAuthorizationStatus __attribute__((warn_unused_result("")));
	[Export ("trackingAuthorizationStatus")]
	//[Verify (MethodToProperty)]
	nint TrackingAuthorizationStatus { get; }
}

// @interface RCTransaction : NSObject
[Obsoleted (PlatformName.MacOSX, 1, 0, message: "'Transaction' has been renamed to 'RCStoreTransaction'")]
[Obsoleted (PlatformName.WatchOS, 1, 0, message: "'Transaction' has been renamed to 'RCStoreTransaction'")]
[Obsoleted (PlatformName.TvOS, 1, 0, message: "'Transaction' has been renamed to 'RCStoreTransaction'")]
[Obsoleted (PlatformName.iOS, 1, 0, message: "'Transaction' has been renamed to 'RCStoreTransaction'")]
[BaseType (typeof(NSObject))]
interface RCTransaction
{
}
