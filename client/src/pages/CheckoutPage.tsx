import {Elements} from '@stripe/react-stripe-js';
import {loadStripe} from '@stripe/stripe-js';
import Checkout from '../components/Checkout';

// Make sure to call `loadStripe` outside of a component’s render to avoid
// recreating the `Stripe` object on every render.
const stripePromise = loadStripe('pk_test_51LmalELaOunyfMqqTHRoNijm8JozipL251frLs1jUfR4OgjpFG0zyFn3HNCWjTLnt9fCorHELLweWEd9lurPQoU600qVUmBhW3');

export default function CheckoutPage() {
 

  return (
    <Elements stripe={stripePromise}>
      <Checkout />
    </Elements>
  );
}
