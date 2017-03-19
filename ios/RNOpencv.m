
#import "RNOpencv.h"

@implementation RNOpencv

RCT_EXPORT_MODULE();

RCT_EXPORT_METHOD(helloWorld:(NSString *)str)
{
    RCTLogInfo(@"%@", str);
}

@end
